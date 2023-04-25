using BlazorDemo.Shared.Data.DataProviders;
using BlazorDemo.Shared.Data.Services;
using DevExpress.Blazor;
using Microsoft.Extensions.Logging;
using DevExpress.Maui;
using CommunityToolkit.Maui;

namespace BlazorDemo.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.UseMauiCommunityToolkit();
            builder.UseDevExpress();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDevExpressBlazor(options => {
                options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
                options.SizeMode = DevExpress.Blazor.SizeMode.Large;
            });
            builder.Services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            builder.Services.AddScoped<IssuesDataService>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
;

            return builder.Build();
        }
    }
}