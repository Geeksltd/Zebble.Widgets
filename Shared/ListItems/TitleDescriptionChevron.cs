using System.Threading.Tasks;

namespace Zebble
{
    public class TitleDescriptionChevron : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-text" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        readonly Stack VerticalRow = new Stack();

        public TitleDescriptionChevron() { }

        internal TitleDescriptionChevron(Bindable<string> titleBinding, Bindable<string> descriptionBinding, Bindable<string> chevronBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Description.Bind("Text", () => descriptionBinding);
            Chevron.Bind("Text", () => chevronBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Title.Css.Padding(left: 15, right: 15, top: 15, bottom: 0);
            Description.Css.Padding(left: 15, right: 15, top: 0, bottom: 15);
            VerticalRow.Css.Width(95.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(VerticalRow.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await Add(VerticalRow);
            await Add(Chevron);
        }
    }
}
