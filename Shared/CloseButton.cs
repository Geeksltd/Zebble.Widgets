using System;
using System.Threading.Tasks;

namespace Zebble
{
    public class CloseButton : TextView
    {
        public CloseButton()
        {
            Css.Padding(8);
            Css.Size(34);
            Css.TextAlignment(Alignment.Middle);

            Text = "✕";
        }
    }
}
