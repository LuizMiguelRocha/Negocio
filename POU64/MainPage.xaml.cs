
using Microsoft.Maui.Controls;
using Negocio;

namespace POU64;


public partial class MainPage : ContentPage
{
	pokemon atual;
	psyduck pato = new psyduck();
	golduck eduardo = new golduck();
	rosa kirby = new rosa();

	public MainPage()
	{
		InitializeComponent();

		atual = pato;
	}

	void TrocaPokemon(object sender, EventArgs args)
	{
		if (atual == pato)
		    atual = eduardo;
		else if (atual == eduardo)
		         atual = kirby;
        else if (atual == kirby)
		         atual = pato;

        
		ProgressBarFome.Progress = atual.GetFome();
		ProgressBarSede.Progress = atual.GetSede();
		ProgressBarSaude.Progress = atual.GetSaude();
	}

}

