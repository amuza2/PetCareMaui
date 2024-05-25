using PetCare.Pages;

namespace PetCare;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new WelcomTo());
    }
}