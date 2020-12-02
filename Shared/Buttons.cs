using System;

namespace Zebble
{
    public class PrimaryButton : Button
    {
        public PrimaryButton(string text = null) => Text = text;

        public Center InCenter()
        {
            var result = new Center();
            result.Add(this).RunInParallel();
            return result;
        }
    }

    public class SecondaryButton : PrimaryButton
    {
        public SecondaryButton() => Css.BackgroundColor = "#686868";
    }
}