using System.Threading.Tasks;

namespace Zebble.Widgets
{
    public class Title : Row
    {
        public readonly TextView TitleControl = new TextView { CssClass = "list-text" };

        public Title() { }

        internal Title(Bindable<string> titleBinding)
        {
            TitleControl.Bind("Text", () => titleBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            TitleControl.Css.Font(size: 17, bold: true).Padding(all: 15);

            await Add(TitleControl);
        }
    }
}
