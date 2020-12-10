using System.Threading.Tasks;

namespace Zebble.Widgets
{
    public class TitleDescriptionIcon : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-text" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        readonly Stack VerticalRow = new Stack();

        public TitleDescriptionIcon() { }

        internal TitleDescriptionIcon(Bindable<string> titleBinding, Bindable<string> descriptionBinding, Bindable<string> iconBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Icon.Css.Size(60);

            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            VerticalRow.Css.Padding(left: 15, top: 10, bottom: 15).Height(new Length.BindingLengthRequest(Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(VerticalRow);
            await Add(Icon);
        }
    }
}
