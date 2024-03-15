namespace MauiDemoNy3
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickedClock(object sender, EventArgs e)
        {
            while(true)
            {
                // Något som ska köras varje sekund
                Clock.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }

        private async void OnClickedGoUserPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UserPage("Micke", 58));
        }

        private async void OnClickedGoUserPageBind(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UserPageBind());
        }

        private async void OnClickedGoShopPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ShopPage());
        }
    }

}
