using System;
using System.Threading.Tasks;

namespace Zebble
{
    public abstract class MainMenu : Stack
    {
        public static MainMenu Current { get; private set; }
        bool IsExpanded, Animating;

        public MainMenu()
        {
            AutoFlash = false;
            Nav.Navigating.Event += Collapse;
            Overlay.Default.Tapped.Event += Collapse;
            Tapped.Event += Collapse;
            Swiped.FullEvent += a => { if (a.Direction == Zebble.Direction.Left) Collapse(); };
            Nav.HardwareBack.FullEvent += x => { if (IsExpanded) { Collapse(); x.Cancel = true; } };

            Css.Width(75.Percent()).Height(100.Percent()).Padding(20).X(-Root.ActualWidth * 0.75f);
        }

        public static async Task Setup<TMenu>() where TMenu : MainMenu, new()
        {
            if (Current != null) return;
            Current = new TMenu();
            await Root.Add(Current, awaitNative: true);
            await Current.BringToFront();
        }

        public async Task Expand()
        {
            if (Animating || IsExpanded) return;
            Animating = true;
            IsExpanded = true;

            await Overlay.Default.Show();
            this.Visible();
            await BringToFront();
            await DoAnimate(() => this.X(0));
        }

        public void Collapse()
        {
            if (Animating || !IsExpanded) return;
            Animating = true;
            IsExpanded = false;

            Overlay.Default.Hide().RunInParallel();
            DoAnimate(() => this.X(-ActualWidth), () => this.Hide());
        }

        Task DoAnimate(Action action, Action then = null)
        {
            var ani = Animation.Create(this, x => action())
                .OnCompleted(() => { then?.Invoke(); Animating = false; });
            return this.Animate(ani);
        }
    }
}
