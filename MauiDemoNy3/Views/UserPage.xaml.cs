namespace MauiDemoNy3.Views;

public partial class UserPage : ContentPage
{
    public int Age { get; set; }
    public string FirstName { get; set; }

    public UserPage(string name, int age)
	{
		InitializeComponent();

		Age = age;
		FirstName = name;

		OnClickedGetUser(null, null);
		
	}

    private async void OnClickedGetUser(object sender, EventArgs e)
    {
		Models.User user = await ViewModels.UserPageViewModel.GetUserAsync();
		if(user != null)
		{
			Username.Text = user.username + FirstName + Age;
			Name.Text = user.name;
			Address.Text = user.address;
		}
    }
}