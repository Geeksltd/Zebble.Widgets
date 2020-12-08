using System;
using System.Threading.Tasks;

namespace Zebble
{
    public abstract class BaseLink : TextView
    {
        bool ShowInCenter;

        public BaseLink(bool showInCenter = false) => ShowInCenter = showInCenter;

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

    public class Link : BaseLink
    {
        public Link(bool showInCenter = false) : base(showInCenter)
        {
            Css.Width(Length.AutoStrategy.Content);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Css.Border(bottom: 1, color: TextColor);
            Css.TextAlignment(Alignment.Middle);
        }
    }

    public class CancelLink : BaseLink
    {
        public CancelLink(bool showInCenter = false) : base(showInCenter)
        {
            Css.TextColor = Color.Parse("#c8c8c8");
            Css.Opacity = 0.7f;
            Css.Margin(vertical: 15);
        }
    }
}
