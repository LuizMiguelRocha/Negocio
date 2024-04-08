using Microsoft.Maui.Controls;
using Negocio;

namespace POU64;


	public partial class Gameover : ContentPage
	{

	public Gameover()
	{
		InitializeComponent();
	}

	public void Voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
	}