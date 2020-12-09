﻿using System.Threading.Tasks;

namespace Zebble
{
    public class ListCard : BaseListItem
    {
        public override async Task OnInitializing()
        {
            ClipChildren = false;
            await base.OnInitializing();

            Css.Margin(all: 15);
            Css.Background(color: Colors.LightGray);
        }
    }
}
