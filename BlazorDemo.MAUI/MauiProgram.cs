using BlazorDemo.Shared.Data.DataProviders;
using BlazorDemo.Shared.Data.Services;
using DevExpress.Maui;

namespace BlazorDemo.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            DevExpress.Maui.Core.ThemeManager.ApplyThemeToSystemBars = true;
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.UseDevExpress();
            builder.UseDevExpressCharts();
            builder.UseDevExpressCollectionView();
            builder.UseDevExpressControls();
            builder.UseDevExpressEditors();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDevExpressBlazor(options => {
                options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
                options.SizeMode = DevExpress.Blazor.SizeMode.Large;
            });
            builder.Services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            builder.Services.AddScoped<IssuesDataService>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
;

            return builder.Build();
        }
    }
}
