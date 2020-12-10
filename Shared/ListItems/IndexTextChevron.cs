using System.Threading.Tasks;

namespace Zebble
{
    public class IndexTextChevron : Row
    {
        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };
        public readonly TextView Chevron = new TextView() { CssClass = "list-chevron" };

        public IndexTextChevron() { }

        internal IndexTextChevron(Bindable<string> indexBinding, Bindable<string> textBinding, Bindable<string> chevronBinding)
        {
            Text.Bind("Text", () => textBinding);
            Index.Bind("Text", () => indexBinding);
            Chevron.Bind("Text", () => chevronBinding);
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);
            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);

            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Text.Height));
            Text.Css.Padding(all: 15).Width(80.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(Text.Height));

            await Add(Index);
            await Add(Text);
            await Add(Chevron);
        }
    }
}
