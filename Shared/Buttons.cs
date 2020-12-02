using System;
using System.Threading.Tasks;

namespace Zebble
{
    public abstract class BaseButton : Button
    {
        bool ShowInCenter;

        public BaseButton(bool showInCenter = false) => ShowInCenter = showInCenter;

        public override async Task OnInitializing()
        {
            await base.OnInitializing();

            if (ShowInCenter) await Add(InCenter());
        }

        Center InCenter()
        {
            var result = new Center();
            result.Add(this).RunInParallel();
            return result;
        }
    }

    public class PrimaryButton : BaseButton
    {
        public PrimaryButton(string text = null, bool showInCenter = false) : base(showInCenter)
        {
            Css.BackgroundColor = "#ff005c";
            Text = text;
        }
    }

    public class SecondaryButton : PrimaryButton
    {
        public SecondaryButton(string text = null, bool showInCenter = false) : base(text, showInCenter) => Css.BackgroundColor = "#686868";
    }
}