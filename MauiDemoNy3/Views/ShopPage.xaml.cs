namespace MauiDemoNy3.Views;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.ShopPageViewModel();
	}

    private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		var product = ((ListView)sender).SelectedItem as Models.Product;

		if (product != null)
		{
			var page = new ShopDetailsPage();
			page.BindingContext = product;
            await Navigation.PushAsync(page);
		}
    }
}