using Zebble;

namespace UI.Templates
{
    public class SafeArea : Canvas
    {
        public SafeArea()
        {
            Css.Height(Root.ActualHeight);
            Css.Padding(top: Zebble.Device.Screen.SafeAreaInsets.Top);
        }
    }
}