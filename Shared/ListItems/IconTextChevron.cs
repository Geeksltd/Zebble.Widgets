using System.Threading.Tasks;

namespace Zebble.Widgets
{
    public class IconTextChevron : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        public IconTextChevron() { }

        internal IconTextChevron(Bindable<string> iconBinding, Bindable<string> textBinding, Bindable<string> chevronBinding)
        {
            Text.Bind("Text", () => textBinding);
            Chevron.Bind("Text", () => chevronBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Icon.Css.Size(60);

            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            Text.Css.Padding(all: 15).Margin(top: 15).Width(70.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));
            Chevron.Css.Margin(top: 15).Height(new Length.BindingLengthRequest(Icon.Height));

            await Add(Icon);
            await Add(Text);
            await Add(Chevron);
        }
    }
}
