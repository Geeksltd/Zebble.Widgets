using System.Threading.Tasks;

namespace Zebble
{
    public class TextChevron : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        public TextChevron() { }

        internal TextChevron(Bindable<string> textBinding, Bindable<string> chevronBinding)
        {
            Text.Bind("Text", () => textBinding);
            Chevron.Bind("Text", () => chevronBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Text.Css.Padding(all: 15).Width(95.Percent());
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10).Height(new Length.BindingLengthRequest(Text.Height));

            await Add(Text);
            await Add(Chevron);
        }
    }
}
