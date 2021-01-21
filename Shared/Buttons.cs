namespace Zebble
{
    public class PrimaryButton : Button
    {
        public PrimaryButton(string text = null)
        {
            Css.BackgroundColor = "#333";
            Text = text;
        }
    }

    public class SecondaryButton : PrimaryButton
    {
        public SecondaryButton(string text = null) : base(text) => Css.BackgroundColor = "#aaa";
    }
}