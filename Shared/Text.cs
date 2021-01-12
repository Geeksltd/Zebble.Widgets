using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class Text : Row
    {
        public readonly TextView TextItem = new TextView { CssClass = "list-text" };

        public Text() { }

        internal Text(Bindable<string> textBinding)
        {
            TextItem.Bind("Text", () => textBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            TextItem.Css.Padding(all: 15);

            await Add(TextItem);
        }
    }
}
