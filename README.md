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

#### ListItem & ListCard

<b>ListItem</b> and <b>ListCard</b> make you able to design your list items easily and both work the same but the <b>ListItem</b> has a divider line below each row and the <b>ListCard</b> shows each row as a card.

| ItemType     | Example         | Result    |
| :----------- | :-----------    | :-------- |
|Text| ``` <ListItem><Text TextItem.Text="SampleText" /></ListItem> ``` | ![lst1] |
|TextChevron| ``` <ListItem><TextChevron Text.Text="SampleText" /></ListItem> ``` | ![lst2] |
|Title| ``` <ListItem><Title TitleItem.Text="SampleTitle" /></ListItem> ``` | ![lst3] |
|TitleChevron| ``` <ListItem><TitleChevron Title.Text="SampleTitle" /></ListItem> ``` | ![lst4] |
|TitleDescription| ``` <ListItem><TitleDescription Title.Text="SampleTitle" Description.Text="Some Description"  /></ListItem> ``` | ![lst5] |
|TitleDescriptionChevron| ``` <ListItem><TitleDescriptionChevron Title.Text="SampleTitle" Description.Text="Some Description"  /></ListItem> ``` | ![lst6] |
|IconText| ``` <ListItem><IconText Text.Text="SampleText" Icon.Path="images/icon.png"  /></ListItem> ``` | ![lst7] |
|IconTextChevron| ``` <ListItem><IconTextChevron Text.Text="SampleText" Icon.Path="images/icon.png"  /></ListItem> ``` | ![lst8] |
|IconTitle| ``` <ListItem><IconTitle Title.Text="SampleTitle" Icon.Path="images/icon.png" /></ListItem> ``` | ![lst9] |
|IconTitleDescription| ``` <ListItem><IconTitleDescription Title.Text="SampleTitle" Icon.Path="images/icon.png" Description.Text="Some Description" /></ListItem> ``` | ![lst10] |
|IconTitleDescriptionChevron| ``` <ListItem><IconTitleDescriptionChevron Title.Text="SampleTitle" Icon.Path="images/icon.png" Description.Text="Some Description" /></ListItem> ``` | ![lst11] |
|IndexText| ``` <ListItem><IndexText Index.Text="0" Text.Text="SampleText" /></ListItem> ``` | ![lst12] |
|IndexTextChevron| ``` <ListItem><IndexTextChevron Index.Text="0" Text.Text="SampleText"  /></ListItem> ``` | ![lst13] |
|IndexTitle| ``` <ListItem><IndexTitle Index.Text="0" Title.Text="SampleTitle"  /></ListItem> ``` | ![lst14] |
|IndexTitleDescription| ``` <ListItem><IndexTitleDescription Index.Text="0" Title.Text="SampleTitle" Description.Text="Some Description"  /></ListItem> ``` | ![lst15] |
|IndexTitleDescriptionChevron| ``` <ListItem><IndexTitleDescriptionChevron Index.Text="0" Title.Text="SampleTitle"  Description.Text="Some Description"  /></ListItem> ``` | ![lst16] |
|TextIcon| ``` <ListItem><TextIcon Text.Text="SampleText" Icon.Path="images/icon.png" /></ListItem> ``` | ![lst17] |
|TitleIcon| ``` <ListItem><TitleIcon Title.Text="SampleTitle" Icon.Path="images/icon.png" /></ListItem> ``` | ![lst18] |
|TitleDescriptionIcon| ``` <ListItem><TitleDescriptionIcon Title.Text="SampleTitle" Icon.Path="images/icon.png" Description.Text="Some Description"  /></ListItem> ``` | ![lst19] |