using System.Threading.Tasks;

namespace Zebble
{
    public class TitleDescription : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-text" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };

        readonly Stack VerticalRow = new Stack();

        public TitleDescription() { }

        internal TitleDescription(Bindable<string> titleBinding, Bindable<string> descriptionBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true).Padding(left: 15, right: 15, top: 15, bottom: 0);
            Description.Css.Font(size: 10).Padding(left: 15, right: 15, top: 0, bottom: 15);

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(VerticalRow);
        }
    }
}
