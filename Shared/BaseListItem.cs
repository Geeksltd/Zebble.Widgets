using System.Threading.Tasks;

namespace Zebble
{
    public enum ListTypes
    {
        Text, TextChevron, Title, TitleChevron, TitleDescription, TitleDescriptionChevron,
        IconText, IconTextChevron, IconTitle, IconTitleDescription, IconTitleDescriptionChevron,
        IndexText, IndexTextChevron, IndexTitle, IndexTitleDescription, IndexTitleDescriptionChevron,
        TextIcon, TitleIcon, TitleDescriptionIcon
    }

    public abstract class BaseListItem : Stack
    {
        readonly Row HorizontalRow = new Row { CssClass = "horizontal-row" };
        readonly Stack VerticalRow = new Stack { CssClass = "vertical-row" };

        public readonly TextView Text = new TextView { CssClass = "list-text" };
        public readonly TextView Title = new TextView { CssClass = "list-title" };
        public readonly TextView Description = new TextView { CssClass = "list-description" };
        public readonly TextView Chevron = new TextView(">") { CssClass = "list-chevron" };
        public readonly TextView Index = new TextView() { CssClass = "list-index" };
        public readonly ImageView Icon = new ImageView() { CssClass = "list-icon" };

        public ListTypes Type { get; set; }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();

            Title.Css.Font(size: 17, bold: true);
            Description.Css.Font(size: 10);
            Chevron.Css.Font(size: 14).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);
            Index.Css.Font(size: 17).TextAlignment(Alignment.Middle).Padding(top: 10, bottom: 10);
            Icon.Css.Size(60);

            await Add(HorizontalRow);
            await RenderType();
        }

        Task RenderType()
        {
            switch (Type)
            {
                case ListTypes.Text: return JustText();
                case ListTypes.TextChevron: return TextChevron();
                case ListTypes.Title: return JustTitle();
                case ListTypes.TitleChevron: return TitleChevron();
                case ListTypes.TitleDescription: return TitleDescription();
                case ListTypes.TitleDescriptionChevron: return TitleDescriptionChevron();
                case ListTypes.IconText: return IconText();
                case ListTypes.IconTextChevron: return IconTextChevron();
                case ListTypes.IconTitle: return IconTitle();
                case ListTypes.IconTitleDescription: return IconTitleDescription();
                case ListTypes.IconTitleDescriptionChevron: return IconTitleDescriptionChevron();
                case ListTypes.IndexText: return IndexText();
                case ListTypes.IndexTextChevron: return IndexTextChevron();
                case ListTypes.IndexTitle: return IndexTitle();
                case ListTypes.IndexTitleDescription: return IndexTitleDescription();
                case ListTypes.IndexTitleDescriptionChevron: return IndexTitleDescriptionChevron();
                case ListTypes.TextIcon: return TextIcon();
                case ListTypes.TitleIcon: return TitleIcon();
                case ListTypes.TitleDescriptionIcon: return TitleDescriptionIcon();
            }

            return Task.CompletedTask;
        }

        async Task JustText()
        {
            Text.Css.Padding(all: 15);

            await HorizontalRow.Add(Text);
        }

        async Task TextChevron()
        {
            Text.Css.Padding(all: 15).Width(95.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(Text.Height));

            await HorizontalRow.Add(Text);
            await HorizontalRow.Add(Chevron);
        }

        async Task JustTitle()
        {
            Title.Css.Padding(all: 15);

            await HorizontalRow.Add(Title);
        }

        async Task TitleChevron()
        {
            Title.Css.Padding(all: 15).Width(95.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(Title.Height));

            await HorizontalRow.Add(Title);
            await HorizontalRow.Add(Chevron);
        }

        async Task TitleDescription()
        {
            Title.Css.Padding(left: 15, right: 15, top: 15, bottom: 0);
            Description.Css.Padding(left: 15, right: 15, top: 0, bottom: 15);

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(VerticalRow);
        }

        async Task TitleDescriptionChevron()
        {
            Title.Css.Padding(left: 15, right: 15, top: 15, bottom: 0);
            Description.Css.Padding(left: 15, right: 15, top: 0, bottom: 15);
            VerticalRow.Css.Width(95.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(VerticalRow.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(VerticalRow);
            await HorizontalRow.Add(Chevron);
        }

        async Task IconText()
        {
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            Text.Css.Padding(all: 15).Margin(top: 15).Width(75.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));

            await HorizontalRow.Add(Icon);
            await HorizontalRow.Add(Text);
        }

        async Task IconTextChevron()
        {
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            Text.Css.Padding(all: 15).Margin(top: 15).Width(70.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));
            Chevron.Css.Margin(top: 15).Height(new Length.BindingLengthRequest(Icon.Height));

            await HorizontalRow.Add(Icon);
            await HorizontalRow.Add(Text);
            await HorizontalRow.Add(Chevron);
        }

        async Task IconTitle()
        {
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            Title.Css.Padding(all: 15).Margin(top: 15).Width(70.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));

            await HorizontalRow.Add(Icon);
            await HorizontalRow.Add(Title);
        }

        async Task IconTitleDescription()
        {
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            VerticalRow.Css.Padding(left: 15, bottom: 15).Margin(top: 15).Width(75.Percent()).Height(new Length.BindingLengthRequest(Icon.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(Icon);
            await HorizontalRow.Add(VerticalRow);
        }

        async Task IconTitleDescriptionChevron()
        {
            Icon.Css.Width(17.Percent()).Margin(top: 15, left: 15, bottom: 15);
            VerticalRow.Css.Padding(left: 15, bottom: 15).Margin(top: 15).Width(70.Percent()).Height(new Length.BindingLengthRequest(Icon.Height)); ;
            Chevron.Css.Margin(top: 15).Height(new Length.BindingLengthRequest(Icon.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(Icon);
            await HorizontalRow.Add(VerticalRow);
            await HorizontalRow.Add(Chevron);
        }

        async Task IndexText()
        {
            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Text.Height));
            Text.Css.Padding(all: 15).Width(85.Percent());

            await HorizontalRow.Add(Index);
            await HorizontalRow.Add(Text);
        }

        async Task IndexTextChevron()
        {
            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Text.Height));
            Text.Css.Padding(all: 15).Width(80.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(Text.Height));

            await HorizontalRow.Add(Index);
            await HorizontalRow.Add(Text);
            await HorizontalRow.Add(Chevron);
        }

        async Task IndexTitle()
        {
            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(Title.Height));
            Title.Css.Padding(all: 15).Width(85.Percent());

            await HorizontalRow.Add(Index);
            await HorizontalRow.Add(Title);
        }

        async Task IndexTitleDescription()
        {
            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(VerticalRow.Height));
            VerticalRow.Css.Padding(all: 10).Width(85.Percent());

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(Index);
            await HorizontalRow.Add(VerticalRow);
        }

        async Task IndexTitleDescriptionChevron()
        {
            Index.Css.Width(10.Percent()).Height(new Length.BindingLengthRequest(VerticalRow.Height));
            VerticalRow.Css.Padding(all: 10).Width(80.Percent());
            Chevron.Css.Height(new Length.BindingLengthRequest(VerticalRow.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(Index);
            await HorizontalRow.Add(VerticalRow);
            await HorizontalRow.Add(Chevron);
        }

        async Task TextIcon()
        {
            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            Text.Css.Padding(all: 15).Width(88.Percent()).Height(new Length.BindingLengthRequest(HorizontalRow.Height));

            await HorizontalRow.Add(Text);
            await HorizontalRow.Add(Icon);
        }

        async Task TitleIcon()
        {
            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            Title.Css.Padding(all: 15).Width(88.Percent()).Height(new Length.BindingLengthRequest(HorizontalRow.Height));

            await HorizontalRow.Add(Title);
            await HorizontalRow.Add(Icon);
        }

        async Task TitleDescriptionIcon()
        {
            Icon.Css.Width(8.Percent()).Height(30).Margin(top: 15, left: 15, bottom: 15);
            VerticalRow.Css.Padding(left: 15, top: 10, bottom: 15).Height(new Length.BindingLengthRequest(HorizontalRow.Height));

            await VerticalRow.Add(Title);
            await VerticalRow.Add(Description);

            await HorizontalRow.Add(VerticalRow);
            await HorizontalRow.Add(Icon);
        }
    }
}
