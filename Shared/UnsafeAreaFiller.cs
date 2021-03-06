﻿namespace Zebble
{
    public class TopUnsafeAreaFiller : Canvas
    {
        public TopUnsafeAreaFiller()
        {
            var top = Device.Screen.SafeAreaInsets.Top;
#if UWP
            if (System.Diagnostics.Debugger.IsAttached && top < 20f)
                top = 20f;
#endif

            Css.Height(top);
        }
    }

    public class BottomUnsafeAreaFiller : Canvas
    {
        public BottomUnsafeAreaFiller() => Css.Height(Device.Screen.SafeAreaInsets.Bottom);
    }
}