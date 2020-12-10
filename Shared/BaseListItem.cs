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
        readonly Bindable<string> TextBinding = new Bindable<string>();
        readonly Bindable<string> IconBinding = new Bindable<string>();
        readonly Bindable<string> ChevronBinding = new Bindable<string>(">");
        readonly Bindable<string> TitleBinding = new Bindable<string>();
        readonly Bindable<string> IndexBinding = new Bindable<string>();
        readonly Bindable<string> DescriptionBinding = new Bindable<string>();

        public ListTypes Type { get; set; }
        public string Text
        {
            get => TextBinding.Value;
            set
            {
                if (value == TextBinding.Value) return;
                TextBinding.Set(value);
            }
        }
        public string Title
        {
            get => TitleBinding.Value;
            set
            {
                if (value == TitleBinding.Value) return;
                TitleBinding.Set(value);
            }
        }
        public string Icon
        {
            get => IconBinding.Value;
            set
            {
                if (value == IconBinding.Value) return;
                IconBinding.Set(value);
            }
        }
        public string Chevron
        {
            get => ChevronBinding.Value;
            set
            {
                if (value == ChevronBinding.Value) return;
                ChevronBinding.Set(value);
            }
        }
        public string Description
        {
            get => DescriptionBinding.Value;
            set
            {
                if (value == DescriptionBinding.Value) return;
                DescriptionBinding.Set(value);
            }
        }
        public string Index
        {
            get => IndexBinding.Value;
            set
            {
                if (value == IndexBinding.Value) return;
                IndexBinding.Set(value);
            }
        }

        public override async Task OnPreRender()
        {
            await base.OnPreRender();
            await RenderTypes();
        }

        Task RenderTypes()
        {
            switch (Type)
            {
                case ListTypes.Text: return Add(new Widgets.Text(TextBinding));
                case ListTypes.TextChevron: return Add(new Widgets.TextChevron(TextBinding, ChevronBinding));
                case ListTypes.Title: return Add(new Widgets.Title(TitleBinding));
                case ListTypes.TitleChevron: return Add(new Widgets.TitleChevron(TitleBinding, ChevronBinding));
                case ListTypes.TitleDescription: return Add(new Widgets.TitleDescription(TitleBinding, DescriptionBinding));
                case ListTypes.TitleDescriptionChevron: return Add(new Widgets.TitleDescriptionChevron(TitleBinding, DescriptionBinding, ChevronBinding));
                case ListTypes.IconText: return Add(new Widgets.IconText(IconBinding, TextBinding));
                case ListTypes.IconTextChevron: return Add(new Widgets.IconTextChevron(IconBinding, TextBinding, ChevronBinding));
                case ListTypes.IconTitle: return Add(new Widgets.IconTitle(IconBinding, TitleBinding));
                case ListTypes.IconTitleDescription: return Add(new Widgets.IconTitleDescription(IconBinding, TitleBinding, DescriptionBinding));
                case ListTypes.IconTitleDescriptionChevron: return Add(new Widgets.IconTitleDescriptionChevron(IconBinding, TitleBinding, DescriptionBinding, ChevronBinding));
                case ListTypes.IndexText: return Add(new Widgets.IndexText(IndexBinding, TextBinding));
                case ListTypes.IndexTextChevron: return Add(new Widgets.IndexTextChevron(IndexBinding, TextBinding, ChevronBinding));
                case ListTypes.IndexTitle: return Add(new Widgets.IndexTitle(IndexBinding, TitleBinding));
                case ListTypes.IndexTitleDescription: return Add(new Widgets.IndexTitleDescription(IndexBinding, TitleBinding, DescriptionBinding));
                case ListTypes.IndexTitleDescriptionChevron: return Add(new Widgets.IndexTitleDescriptionChevron(IndexBinding, TitleBinding, DescriptionBinding, ChevronBinding));
                case ListTypes.TextIcon: return Add(new Widgets.TextIcon(TextBinding, IconBinding));
                case ListTypes.TitleIcon: return Add(new Widgets.TitleIcon(TitleBinding, IconBinding));
                case ListTypes.TitleDescriptionIcon: return Add(new Widgets.TitleDescriptionIcon(TitleBinding, DescriptionBinding, IconBinding));
            }

            return Task.CompletedTask;
        }
    }
}
