<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/632326528/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1162029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Use DevExpress MAUI and Blazor Components to Create a Blazor Hybrid Application

A demo of DevExpress Blazor and MAUI components in a Blazor Hybrid scenario.

## Files to Review

* [BlazorDemo.Shared/Components](./BlazorDemo.Shared/Components) - shared Razor components for MAUI and Blazor.
* [BlazorDemo.Shared/Data](./BlazorDemo.Shared/Data) - shared data layer.
* [BlazorDemo.Server/Pages/GridPage.razor](./BlazorDemo.Server/Pages/GridPage.razor) - Razor component usage in Blazor Server.
* [BlazorDemo.MAUI/Pages/GridPage.razor](./BlazorDemo.MAUI/Pages/GridPage.razor) - Razor component usage in MAUI.
* [BlazorDemo.Server/Program.cs](./BlazorDemo.Server/Program.cs) - data layer registration, database initialization, DevExpress size mode in Blazor Server.
* [BlazorDemo.MAUI/MauiProgram.cs](./BlazorDemo.MAUI/MauiProgram.cs) - data layer registration and DevExpress size mode in MAUI (size mode is set to Large instead of Medium).
* [BlazorDemo.MAUI/MauiViews](./BlazorDemo.MAUI/MauiViews) - views built with MAUI.
* [BlazorDemo.MAUI/MauiViews/HybridGridPage.xaml](./BlazorDemo.MAUI/MauiViews/HybridGridPage.xaml) - a MAUI view that references a Razor component.
