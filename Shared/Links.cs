using System;
using System.Threading.Tasks;

namespace Zebble
{
    public class Link : TextView
    {
        public Link()
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

    public class CancelLink : TextView
    {
        public CancelLink()
        {
            Css.TextColor = Color.Parse("#c8c8c8");
            Css.Opacity = 0.7f;
            Css.Margin(vertical: 15);
        }
    }
}
