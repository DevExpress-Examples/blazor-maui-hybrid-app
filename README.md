<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/632326528/23.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1162029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Use DevExpress MAUI and Blazor Components to Create a .NET MAUI Blazor Hybrid app

This demo example shows how to utilize DevExpress Blazor and .NET MAUI components to develop a .NET MAUI Blazor Hybrid app. 

## Blazor Hybrid View

<img src="media/hybrid-view.png" alt=".NET MAUI Blazor Hybrid view" height="400">

This page uses the DevExpress Blazor Grid to display a list of tasks. When the app is viewed on smaller screen sizes, adaptive triggers reduce the number of columns and display a column chooser button. 

The code for this view is shared between MAUI and Blazor Server apps. The MAUI version uses a larger size mode.

**Files to look at:** [HybridGridPage.xaml](./BlazorDemo.MAUI/MauiViews/HybridGridPage.xaml), [MauiProgram.cs](./BlazorDemo.MAUI/MauiProgram.cs), [GridList.razor](./BlazorDemo.Shared/Components/GridList.razor)

**Read more:** [Blazor Size Modes](https://docs.devexpress.com/Blazor/401784/common-concepts/customize-appearance/size-modes), [Adaptive Layout API](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint)

## Views Built with MAUI

<img src="media/maui-views.png" alt="Views built with the DevExpress for .NET MAUI library" height="400">

### Login View

This page shows how to implement a login UI in your .NET MAUI application.

**Available user:** "User" with the password "123".

**File to look at:** [LoginPage.xaml](BlazorDemo.MAUI/MauiViews/LoginPage.xaml)

**Read more:** [Authentication](https://docs.devexpress.com/MAUI/404307/scenarios/authenticate)

### Blogs View

This page uses our [DXCollectionView](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView?p=netframework) component to show a collection of items. Note the infinite scrolling feature - the component loads batches of items on demand.

**File to look at:** [BlogsPage.xaml](BlazorDemo.MAUI/MauiViews/BlogsPage.xaml)

**Read more:** [Infinite Scrolling](https://docs.devexpress.com/MAUI/404358/scenarios/infinite-grid-scroll)

### Analytics View

This page shows how to use our [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) components to create clickable cards.

**File to look at:** [AnalyticsPage.xaml](BlazorDemo.MAUI/MauiViews/AnalyticsPage.xaml)

**Read more:** [Cards with Custom Content](https://docs.devexpress.com/MAUI/404341/scenarios/buttons-and-charts-in-cards)

## Documentation

* [Build a .NET MAUI Blazor Hybrid app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-7.0&pivots=windows)
