namespace Zebble
{
    public class Row : Stack
    {
        public Row()
        {
            Direction = RepeatDirection.Horizontal;
            ClipChildren = false;
        }
    }
}
