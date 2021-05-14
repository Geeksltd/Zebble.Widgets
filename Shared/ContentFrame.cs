using System.Threading.Tasks;

namespace Zebble
{
    public class ContentFrame : Stack
    {
        public ContentFrame() { }

        public override async Task OnInitializing()
        {
            await base.OnInitializing();

            Css.Background(color: Colors.LightGray);
            Css.Margin(all: 15);
            Css.Padding(all: 15);
        }
    }
}