using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class TitleIcon : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        public TitleIcon() { }

        internal TitleIcon(Bindable<string> titleBinding, Bindable<string> iconBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Icon.Bind("Path", () => iconBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Icon.Css.Size(60);

            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            Title.Css.Padding(all: 15).Width(88.Percent()).Height(new Length.BindingLengthRequest(Height));

            await Add(Title);
            await Add(Icon);
        }
    }
}