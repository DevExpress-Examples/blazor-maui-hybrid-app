<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/632326528/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1162029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Use DevExpress MAUI and Blazor Components to Create a .NET MAUI Blazor Hybrid app

This demo example shows how to utilize DevExpress Blazor and .NET MAUI components to develop a .NET MAUI Blazor Hybrid app. 

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

