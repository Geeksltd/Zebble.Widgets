using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IndexText : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };

        public IndexText() { }

        internal IndexText(Bindable<string> indexBinding, Bindable<string> textBinding)
        {
            Index.Bind("Text", () => indexBinding);
            Text.Bind("Text", () => textBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Text.Height));
            Text.Css.Padding(all: 15).Width(85.Percent());

            await Add(Index);
            await Add(Text);
        }
    }
}
