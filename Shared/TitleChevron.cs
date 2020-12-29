using System.Threading.Tasks;

namespace Zebble
{
    public class TitleChevron : Row
    {
        public readonly TextView Title = new TextView { CssClass = "list-text" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        public TitleChevron() { }

        internal TitleChevron(Bindable<string> titleBinding, Bindable<string> chevronBinding)
        {
            Title.Bind("Text", () => titleBinding);
            Chevron.Bind("Text", () => chevronBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Title.Css.Padding(all: 15).Width(95.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(Title.Height));

            await Add(Title);
            await Add(Chevron);
        }
    }
}
