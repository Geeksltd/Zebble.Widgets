using Olive;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Zebble
{
    public class Tooltip : Stack
    {
        readonly Stack Arrow = new Stack().CssClass("arrow").Background(color: Colors.White).Size(8).Rotation(45);
        readonly TextView Content = new TextView().CssClass("content").Background(color: Colors.White).TextColor(Colors.Black).Font(size: 12).TextAlignment(Alignment.Middle).Padding(5).Width(Length.AutoStrategy.Content).BorderRadius(all: 5);

        public override async Task OnInitializing()
        {
            await base.OnInitializing();

            this.Hide().Absolute().ZIndex(10000).Width.BindTo(Content.Width);

            Arrow.X.BindTo(Width, Arrow.Width, (pw, aw) => (pw / 2) - (aw / 2));
            Arrow.Margin.Top.BindTo(Arrow.Height, ah => ah / 4);

            Content.Margin.Top.BindTo(Arrow.Height, ah => -ah / 2);

            await AddRange(new View[] { Arrow, Content });
        }

        public async static Task<Tooltip> GetInstance(View injectTo = null)
        {
            injectTo ??= Root;

            var instance = injectTo.FindDescendent<Tooltip>();
            if (instance is null) instance = await injectTo.Add(new Tooltip());

            return instance;
        }

        CancellationTokenSource CancellationSource;

        public async Task Show(View relative, string text, TimeSpan? duration = null)
        {
            _ = relative ?? throw new ArgumentNullException(nameof(relative));

            if (text.IsEmpty()) return;
            Content.Text(text);

            duration ??= 1500.Milliseconds();

            UIWorkBatch.RunSync(() =>
            {
                X.BindTo(relative.Width, Width, (rw, w) => (relative.CalculateAbsoluteX() + (rw / 2)) - (w / 2));
                Y.BindTo(relative.Height, rh => relative.CalculateAbsoluteY() + rh);
            });

            this.Visible();

            CancellationSource?.Cancel();
            CancellationSource?.Dispose();
            CancellationSource = new();

            await Task.Delay(duration.Value, CancellationSource.Token)
                      .ContinueWith((_) => this.Hide(), CancellationSource.Token);
        }
    }
}
