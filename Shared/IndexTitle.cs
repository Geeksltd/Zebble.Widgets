using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IndexTitle : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };

        public IndexTitle() { }

        internal IndexTitle(Bindable<string> indexBinding, Bindable<string> titleBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Index.Bind("Text", () => indexBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Title.Height));
            Title.Css.Padding(all: 15).Width(85.Percent());

            await Add(Index);
            await Add(Title);
        }
    }
}
