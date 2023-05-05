using MauiApp1.Models;
using MauiApp1.Services;

namespace MauiApp1.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

		

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        PokeApiClient pokeClient = new PokeApiClient();
        //NamedApiResourceList<Pokemon> lotsMoreBPage = await pokeClient.GetNamedResourcePageAsync<Pokemon>();
        NamedApiResourceList<Pokemon> allPokes = await pokeClient.GetNamedResourcePageAsync<Pokemon>(150, 0);

    }
}