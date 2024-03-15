namespace MauiDemoNy3.Views;

public partial class UserPageBind : ContentPage
{
	public UserPageBind()
	{
		InitializeComponent();
		BindingContext = new ViewModels.UserPageViewModel(); // .TheUser;
	}


}