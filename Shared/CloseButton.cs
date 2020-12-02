using System;
using System.Threading.Tasks;

namespace Zebble
{
    public class CloseButton : TextView
    {
        Func<Task> Action;

        public CloseButton(Func<Task> action = null)
        {
            Css.Padding(8);
            Css.Size(34);
            Css.TextAlignment(Alignment.Middle);

            Text = "✕";

            Touched.Handle(OnTouched);

            Action = action;
        }

        Task OnTouched() => Action?.Invoke();
    }
}
