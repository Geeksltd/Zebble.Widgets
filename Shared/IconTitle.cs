using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IconTitle : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        public IconTitle() { }

        internal IconTitle(Bindable<string> iconBinding, Bindable<string> titleBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Icon.Css.Size(60);
            Title.Css.Font(size: 17, bold: true);

            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            Title.Css.Padding(all: 15).Margin(top: 15).Width(70.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));

            await Add(Icon);
            await Add(Title);
        }
    }
}
