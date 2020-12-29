using System.Threading.Tasks;

namespace Zebble
{
    public class IndexTitleDescriptionChevron : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        readonly Stack VerticalRow = new Stack();

        public IndexTitleDescriptionChevron() { }

        internal IndexTitleDescriptionChevron(Bindable<string> indexBinding, Bindable<string> titleBinding, Bindable<string> descriptionBinding, Bindable<string> chevronBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
            Index.Bind("Text", () => indexBinding);
            Chevron.Bind("Text", () => chevronBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);
            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(VerticalRow.Height));
            VerticalRow.Css.Padding(all: 10).Width(80.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(VerticalRow.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(Index);
            await Add(VerticalRow);
            await Add(Chevron);
        }
    }
}
