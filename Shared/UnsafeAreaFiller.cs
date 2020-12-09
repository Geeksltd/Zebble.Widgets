using Zebble;
using System;

namespace UI.Templates
{
    public class TopUnsafeAreaFiller : Canvas
    {
        public TopUnsafeAreaFiller()
        {
            Css.Padding(top: GetValue());
        }

        float GetValue()
        {
            var result = Zebble.Device.Screen.SafeAreaInsets.Top;

#if UWP
            if (System.Diagnostics.Debugger.IsAttached)
                result = result.LimitMin(30f);
#endif

            return result;
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