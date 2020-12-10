[logo]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/NuGet/Icon.png "Zebble.Widgets"
[row]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Row.PNG "Row ScreenShot"
[center]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Center.PNG "Center ScreenShot"
[closeicon]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Row.PNG "CloseIcon ScreenShot"
[contentframe]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/ContentFrame.PNG "ContentFrame ScreenShot"
[links]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Links.PNG "Links ScreenShot"
[buttons]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Buttons.PNG "Buttons ScreenShot"
[lst1]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Text.PNG "Result Text"
[lst2]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TextChervon.PNG "Result TextChevron"
[lst3]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/Title.PNG "Result Title"
[lst4]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TitleChervon.PNG "Result TitleChevron"
[lst5]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TitleDescription.PNG "Result TitleDescription"
[lst6]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TitleDescriptionChevron.PNG "Result TitleDescriptionChevron"
[lst7]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IconText.PNG "Result IconText"
[lst8]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IconTextChevron.PNG "Result IconTextChevron"
[lst9]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IconTitle.PNG "Result IconTitle"
[lst10]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IconTitleDescription.PNG "Result IconTitleDescription"
[lst11]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IconTitleDescriptionChevron.PNG "Result IconTitleDescriptionChevron"
[lst12]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IndexText.PNG "Result IndexText"
[lst13]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IndexTextChevron.PNG "Result IndexTextChevron"
[lst14]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IndexTitle.PNG "Result IndexTitle"
[lst15]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IndexTitleDescription.PNG "Result IndexTitleDescription"
[lst16]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/IndexTitleDescriptionChevron.PNG "Result IndexTitleDescriptionChevron"
[lst17]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TextIcon.PNG "Result TextIcon"
[lst18]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TitleIcon.PNG "Result TitleIcon"
[lst19]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/Screenshots/TitleDescriptionIcon.PNG "Result TitleDescriptionIcon"

## Zebble.Widgets

![logo]

A Zebble plugin that contains different components which help you to create simple UI.


[![NuGet](https://img.shields.io/nuget/v/Zebble.Widgets.svg?label=NuGet)](https://www.nuget.org/packages/Zebble.Widgets/)

<br>

### Setup
* Available on NuGet: [https://www.nuget.org/packages/Zebble.Widgets/](https://www.nuget.org/packages/Zebble.Widgets/)
* Install in your platform client projects.
* Available for iOS, Android and UWP.
<br>


### Components

### Row

You can use this element to show some elements horizontally. There is an example to create a header which contains a title and a close button ([implementation](/Shared/Row.cs)):

```xml
<Row Id="Header">
    <TextView CssClass="title" Text="@{Title}" />
    <CloseButton Id="Close" on-Touched="CloseTouched" />
</Row>
```
<br>

![row]

---

### Center

This element is using to show an element in the middle (horizontally) of its parents ([implementation](/Shared/Center.cs)).

```xml
<z-place inside="Body">
    <Center>
      <PrimaryButton Text="Button1" />
    </Center>
    <Center>
      <PrimaryButton Text="Button2" />
    </Center>
  </z-place>
```
<br>

![center]

---

### CloseIcon

You can use this element to create a close button for a page or a popup like below ([implementation](/Shared/CloseButton.cs)):

```xml
<Row Id="Header">
    <TextView CssClass="title" Text="@{Title}" />
    <CloseButton Id="Close" on-Touched="CloseTouched" />
</Row>
```
<br>

![closeicon]

---

### ContentFrame

The ContentFrame is a container which by default has some predefined styles to show the elements like a card ([implementation](/Shared/ContentFrame.cs)).

```xml
<z-place inside="Body">
<ContentFrame>
  <Row Id="Header">
      <TextView CssClass="title" Text="@{Title}" />
      <CloseButton Id="Close" on-Touched="CloseTouched" />
  </Row>
  <Center>
    <SecondaryButton Text="Login" z-nav-forward="Pages.LoginPage" />
  </Center>
</ContentFrame>
</z-place>

```
<br>

![contentframe]

---

### Primary and Secondary buttons

([implementation](/Shared/Buttons.cs))

```xml
<z-place inside="Body">
    <Center>
      <PrimaryButton Text="Button1" />
    </Center>
    <Center>
      <SecondaryButton Text="Button2" />
    </Center>
</z-place>
```
<br>

![buttons]

---

### Link

This element is a button with a Link style ([implementation](/Shared/Links.cs)).

```xml
<Center>
  <Link Text="Google" on-Tapped="OnGoogleLinkTapped"/>
</Center>
<Center>
  <CancelLink Id="MyCancelLink" on-Tapped="OptionsTapped" Text="Options" />
</Center>
```
<br>

![links]

---

### SafeArea

The purpose of SafeArea is to render content within the safe area boundaries of a device ([implementation](/Shared/SafeArea.cs)).

```csharp
public class MyPage : Page
{
    public SafeArea SafeAreaContainer = new SafeArea();
    public ScrollView BodyScroller = new ScrollView().Id("BodyScroller");
    public Stack Body;

    protected override async Task InitializeFromMarkup()
    {
        await base.InitializeFromMarkup();

        await Add(SafeAreaContainer);
        await SafeAreaContainer.Add(BodyScroller);
        await BodyScroller.Add(Body = new Stack().Id("Body"));
    }
}
```

---

#### ListItem & ListCard

<b>ListItem</b> and <b>ListCard</b> make you able to design your list items easily and both work the same but the <b>ListItem</b> has a divider line below each row and the <b>ListCard</b> shows each row as a card.

| ItemType     | Example         | Result    |
| :----------- | :-----------    | :-------- |
|Text| ``` <ListItem Type="@ListTypes.Text" Text="SampleText" />  ``` | ![lst1] |
|TextChevron| ``` <ListItem Type="@ListTypes.TextChevron" Text="SampleText" />  ``` | ![lst2] |
|Title| ``` <ListItem Type="@ListTypes.Title" Title="SampleTitle" />  ``` | ![lst3] |
|TitleChevron| ``` <ListItem Type="@ListTypes.TitleChevron" Title="SampleTitle" />  ``` | ![lst4] |
|TitleDescription| ``` <ListItem Type="@ListTypes.TitleDescription" Title="SampleTitle" Description="SampleDescription" />  ``` | ![lst5] |
|TitleDescriptionChevron| ``` <ListItem Type="@ListTypes.TitleDescriptionChevron" Title="SampleTitle" Description="SampleDescription"  />  ``` | ![lst6] |
|IconText| ``` <ListItem Type="@ListTypes.IconText" Text="SampleText" Icon="images/icon.png" />  ``` | ![lst7] |
|IconTextChevron| ``` <ListItem Type="@ListTypes.IconTextChevron" Text="SampleText" Icon="images/icon.png" />  ``` | ![lst8] |
|IconTitle| ``` <ListItem Type="@ListTypes.IconTitle" Title="SampleTitle" Icon="images/icon.png" />  ``` | ![lst9] |
|IconTitleDescription| ``` <ListItem Type="@ListTypes.IconTitleDescriptionChevron" Title="SampleTitle" Icon="images/icon.png" Description="SampleDescription" />  ``` | ![lst10] |
|IconTitleDescriptionChevron| ``` <ListItem Type="@ListTypes.IconTitleDescription" Title="SampleTitle" Icon="images/icon.png" Description="SampleDescription" />  ``` | ![lst11] |
|IndexText| ``` <ListItem Type="@ListTypes.IndexText" Text="SampleText" Index="1" />  ``` | ![lst12] |
|IndexTextChevron| ``` <ListItem Type="@ListTypes.IndexTextChevron" Text="SampleText" Index="1" />  ``` | ![lst13] |
|IndexTitle| ``` <ListItem Type="@ListTypes.IndexTitle" Title="SampleTitle" Index="1" />  ``` | ![lst14] |
|IndexTitleDescription| ``` <ListItem Type="@ListTypes.IndexTitleDescription" Title="SampleTitle" Index="1" Description="SampleDescription" />  ``` | ![lst15] |
|IndexTitleDescriptionChevron| ``` <ListItem Type="@ListTypes.IndexTitleDescriptionChevron" Title="SampleTitle" Index="1" Description="SampleDescription" />  ``` | ![lst16] |
|TextIcon| ``` <ListItem Type="@ListTypes.TextIcon" Text="SampleText" Icon="images/icon.png" />  ``` | ![lst17] |
|TitleIcon| ``` <ListItem Type="@ListTypes.TitleIcon" Title="SampleTitle" Icon="images/icon.png" />  ``` | ![lst18] |
|TitleDescriptionIcon| ``` <ListItem Type="@ListTypes.TitleDescriptionIcon" Title="SampleTitle" Icon="images/icon.png" Description="SampleDescription" />  ``` | ![lst19] |