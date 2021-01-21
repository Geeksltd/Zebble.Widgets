using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IconText : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        public IconText() { }

        internal IconText(Bindable<string> iconBinding, Bindable<string> textBinding)
        {
            Text.Bind("Text", () => textBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Icon.Css.Size(60);
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);

            Text.Css
                .Padding(all: 15)
                .Margin(top: 15)
                .Width(75.Percent())
                .Height(new Length.BindingLengthRequest(Icon.Height));

            await Add(Icon);
            await Add(Text);
        }
    }
}