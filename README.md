<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/632326528/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1162029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Use DevExpress MAUI and Blazor Components to Create a .NET MAUI Blazor Hybrid app

This demo example shows how to utilize DevExpress Blazor and .NET MAUI components to develop a .NET MAUI Blazor Hybrid app. 

## Views Built with MAUI

<img src="media/maui-views.png" alt="Views built with the DevExpress for .NET MAUI library" height="400">

### Login View

This page shows how to implement a login UI in your .NET MAUI application.

**Available user:** "User" with the password "123".

**File to look at:** [LoginPage.xaml](BlazorDemo.MAUI/MauiViews/LoginPage.xaml)

**Read more:** [Authentication](https://docs.devexpress.com/MAUI/404307/scenarios/authenticate)

### Blogs View

This page uses our [DXCollectionView](https://docs.devexpress.com/MAUI/DevExpress.Maui.CollectionView.DXCollectionView?p=netframework) component to show a collection of items with infinite scrolling.

**File to look at:** [BlogsPage.xaml](BlazorDemo.MAUI/MauiViews/BlogsPage.xaml)

**Read more:** [Infinite Scrolling](https://docs.devexpress.com/MAUI/404358/scenarios/infinite-grid-scroll)

### Analytics View

This page shows how to use our [SimpleButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.SimpleButton) components to create clickable cards.

**File to look at:** [AnalyticsPage.xaml](BlazorDemo.MAUI/MauiViews/AnalyticsPage.xaml)

**Read more:** [Cards with Custom Content](https://docs.devexpress.com/MAUI/404341/scenarios/buttons-and-charts-in-cards)

## Files to Review

* [BlazorDemo.Shared/Components](./BlazorDemo.Shared/Components) -- Shared Razor components for MAUI and Blazor.
* [BlazorDemo.Shared/Data](./BlazorDemo.Shared/Data) -- Shared data layer.
* [BlazorDemo.Server/Pages/GridPage.razor](./BlazorDemo.Server/Pages/GridPage.razor) -- Razor component usage in Blazor Server.
* [BlazorDemo.MAUI/Pages/GridPage.razor](./BlazorDemo.MAUI/Pages/GridPage.razor) -- Razor component usage in MAUI.
* [BlazorDemo.Server/Program.cs](./BlazorDemo.Server/Program.cs) -- Data layer registration, database initialization, DevExpress size mode in Blazor Server.
* [BlazorDemo.MAUI/MauiProgram.cs](./BlazorDemo.MAUI/MauiProgram.cs) -- Data layer registration and DevExpress size mode in MAUI (size mode is set to Large instead of Medium).
* [BlazorDemo.MAUI/MauiViews](./BlazorDemo.MAUI/MauiViews) -- Views built with MAUI.
* [BlazorDemo.MAUI/MauiViews/HybridGridPage.xaml](./BlazorDemo.MAUI/MauiViews/HybridGridPage.xaml) -- A MAUI view that references a Razor component.

## Documentation

* [Build a .NET MAUI Blazor Hybrid app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-7.0&pivots=windows)

