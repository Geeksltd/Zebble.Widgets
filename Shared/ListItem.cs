using System.Threading.Tasks;

namespace Zebble
{
    public class ListItem : BaseListItem
    {
        public override async Task OnInitializing()
        {
            await base.OnInitializing();

            Css.Border(bottom: 1, color: Colors.Gray);
        }
    }
}
