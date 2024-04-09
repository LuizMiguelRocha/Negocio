

using Microsoft.Maui.Controls;
using Microsoft.Maui.Dispatching;
using Negocio;

namespace POU64;


public partial class MainPage : ContentPage
{
	pokemon atual;
	psyduck pato;
	margi peixe;
	rosa kirby;

	IDispatcherTimer timer;

	public MainPage()
	{
		InitializeComponent();

		pato = new psyduck();
		peixe = new margi();
		kirby = new rosa();

		atual = pato;

		timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(3);
		timer.Tick += (s, e) => Tempo();
		timer.Start();

		
		ProgressBarFome.Progress = atual.GetFome();
		ProgressBarSede.Progress = atual.GetSede();
		ProgressBarSaude.Progress = atual.GetSaude();
	}

	void Tempo()
	{
		atual.SetFome(atual.GetFome() - 0.05);
		ProgressBarFome.Progress = atual.GetFome();

		atual.SetSede(atual.GetSede() - 0.1);
		ProgressBarSede.Progress = atual.GetSede();

		atual.SetSaude(atual.GetSaude() - 0.02);
		ProgressBarSaude.Progress = atual.GetSaude();

		if (atual.GetMorto())
		{
			timer.Stop();
			Application.Current.MainPage= new Gameover();
		}
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

