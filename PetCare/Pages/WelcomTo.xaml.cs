namespace PetCare.Pages;

public partial class WelcomTo : ContentPage
{
	public WelcomTo()
	{
		InitializeComponent();
	}

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnSignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreatAcPage());
    }
}