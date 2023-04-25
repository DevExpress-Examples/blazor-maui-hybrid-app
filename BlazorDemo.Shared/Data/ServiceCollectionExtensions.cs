using BlazorDemo.Shared.Data.DataProviders;
using BlazorDemo.Shared.Data.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Server.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddIssueServices(this IServiceCollection services) {
            services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            services.AddScoped<IssuesDataService>();
        }
    }
}
