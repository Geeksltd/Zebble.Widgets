[logo]: https://raw.githubusercontent.com/Geeksltd/Zebble.Widgets/master/Shared/NuGet/Icon.png "Zebble.Widgets"


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

#### Row

You can use this element to show some elements horizontally. There is an example to create a header which contains a title and a close button:

```xml
<Row Id="Header">
    <TextView CssClass="title" Text="@{Title}" />
    <CloseButton Id="Close" on-Touched="CloseTouched" />
</Row>
```


#### Center

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

#### CloseIcon

You can use this element to create a close button for a page or a popup like below:

```xml
<Row Id="Header">
    <TextView CssClass="title" Text="@{Title}" />
    <CloseButton Id="Close" on-Touched="CloseTouched" />
</Row>
```

#### ContentFrame

The ContentFrame is a container which by default has some predefined styles to show the elements like a card.

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

#### Primary and Secondary buttons

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

#### Link

This element is a button with a Link style

```xml
<Center>
  <Link Text="Google" on-Tapped="OnGoogleLinkTapped"/>
</Center>
<Center>
  <CancelLink Id="MyCancelLink" on-Tapped="OptionsTapped" Text="Options" />
</Center>
```

#### SafeArea

The purpose of SafeArea is to render content within the safe area boundaries of a device.

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

#### ListItem & ListCard


