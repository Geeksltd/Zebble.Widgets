using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class Title : Row
    {
        public readonly TextView TitleItem = new TextView { CssClass = "list-text" };

        public Title() { }

        internal Title(Bindable<string> titleBinding) => TitleItem.Bind("Text", () => titleBinding);

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            TitleItem.Css.Font(size: 17, bold: true).Padding(all: 15);

            await Add(TitleItem);
        }
    }
}