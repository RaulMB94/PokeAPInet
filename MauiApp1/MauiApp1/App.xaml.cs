using MauiApp1.Pages;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


		var navPage = new NavigationPage(new Home());

		navPage.Background = Colors.Chocolate;

        MainPage = navPage;
	}
}
