using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class TextIcon : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        public TextIcon() { }

        internal TextIcon(Bindable<string> textBinding, Bindable<string> iconBinding)
        {
            Text.Bind("Text", () => textBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Icon.Css.Size(60);

            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            Text.Css.Padding(all: 15).Width(88.Percent()).Height(new Length.BindingLengthRequest(Height));

            await Add(Text);
            await Add(Icon);
        }
    }
}