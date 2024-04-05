

using Microsoft.Maui.Controls;
using Negocio;

namespace POU64;


public partial class MainPage : ContentPage
{
	pokemon atual;
	psyduck pato = new psyduck();
	margi peixe = new margi();
	rosa kirby = new rosa();

	public MainPage()
	{
		InitializeComponent();

		atual = pato;
	}

	void TrocaPokemon(object sender, EventArgs args)
	{
		if (atual == pato)
		    atual = peixe;
		else if (atual == peixe)
		         atual = kirby;
        else if (atual == kirby)
		         atual = pato;

        Troca.Source = atual.GetOutroPokemon();
		ProgressBarFome.Progress = atual.GetFome();
		ProgressBarSede.Progress = atual.GetSede();
		ProgressBarSaude.Progress = atual.GetSaude();
	}

	void Cume(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome() +0.1);
		ProgressBarFome.Progress = atual.GetFome();
	}

	void Agua(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede() +0.1);
		ProgressBarSede.Progress = atual.GetSede();
	}

	void Cura(object sender, EventArgs args)
	{
		atual.SetSaude(atual.GetSaude() +0.1);
		ProgressBarSaude.Progress = atual.GetSaude();
	}

}

