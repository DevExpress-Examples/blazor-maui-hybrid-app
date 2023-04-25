using BlazorDemo.Server.Data;
using BlazorDemo.Shared.Data;
using BlazorDemo.Shared.Data.DataProviders;
using BlazorDemo.Shared.Data.Services;
using DevExpress.Utils.Drawing;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
    options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
});
builder.Services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
builder.Services.AddScoped<IssuesDataService>();
//builder.Services.AddDbContextFactory<IssuesContext>(opt => {
//    opt.UseSqlite($"Data Source={Path.Combine(System.AppContext.BaseDirectory, "DataSources", "issue-list.db")}");
//});
builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();