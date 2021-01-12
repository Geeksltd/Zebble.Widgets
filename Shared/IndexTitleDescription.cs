using System.Threading.Tasks;
using Olive;

namespace Zebble
{
    public class IndexTitleDescription : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };

        readonly Stack VerticalRow = new Stack();

        public IndexTitleDescription() { }

        internal IndexTitleDescription(Bindable<string> indexBinding, Bindable<string> titleBinding, Bindable<string> descriptionBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
            Index.Bind("Text", () => indexBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(VerticalRow.Height));
            VerticalRow.Css.Padding(all: 10).Width(85.Percent());

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(Index);
            await Add(VerticalRow);
        }
    }
}
