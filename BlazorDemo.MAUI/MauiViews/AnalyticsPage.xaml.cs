namespace BlazorDemo.MAUI.MauiViews;

public partial class AnalyticsPage : ContentPage
{
	public AnalyticsPage()
	{
		InitializeComponent();
	}
    private async void AnalyticsItemClicked(object sender, EventArgs e) {
        await DisplayAlert("Clicked", "Navigate to a detail view here", "OK");
    }
}