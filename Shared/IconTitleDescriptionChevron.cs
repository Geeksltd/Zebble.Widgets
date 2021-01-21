using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IconTitleDescriptionChevron : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        readonly Stack VerticalRow = new Stack();

        public IconTitleDescriptionChevron() { }

        internal IconTitleDescriptionChevron(Bindable<string> iconBinding, Bindable<string> titleBinding, Bindable<string> descriptionBinding, Bindable<string> chevronBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
            Chevron.Bind("Text", () => chevronBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);
            Icon.Css.Size(60);

            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);

            VerticalRow.Css
                .Padding(left: 15, bottom: 15)
                .Margin(top: 15)
                .Width(70.Percent())
                .Height(new Length.BindingLengthRequest(Icon.Height));

            Chevron.Css.Margin(top: 15).Height(new Length.BindingLengthRequest(Icon.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(Icon);
            await Add(VerticalRow);
            await Add(Chevron);
        }
    }
}