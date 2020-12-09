using Zebble;

namespace UI.Templates
{
    public class TopUnsafeAreaFiller : Canvas
    {
        public TopUnsafeAreaFiller()
        {
            Css.Padding(top: Zebble.Device.Screen.SafeAreaInsets.Top);
        }
    }

    public class BottomUnsafeAreaFiller : Canvas
    {
        public BottomUnsafeAreaFiller()
        {
            Css.Padding(bottom: Zebble.Device.Screen.SafeAreaInsets.Bottom);
        }
    }
}