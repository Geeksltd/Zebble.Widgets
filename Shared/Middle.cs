namespace Zebble
{
    using Olive;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

  public  class Middle : Stack
    {
        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            var container = FindParent<ScrollView>();

            if (container is null)
            {
                Log.For(this).Warning("Zebble.Middle expects to be inside a scroll view.");
                return;
            }

            var inPath = GetAllParents().TakeWhile(x => x != container).SelectMany(v => new[] { v.Padding.Top, v.Margin.Top }).ToArray();

            Margin.Top.BindTo(container.Height, Height, (x, y) => ((x - y) / 2 - inPath.Sum(x => x.CurrentValue)).LimitMin(0));

            foreach (var i in inPath)
                Margin.Top.UpdateOn(i.Changed);
        }
    }
}