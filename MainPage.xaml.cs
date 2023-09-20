using Microsoft.Maui.Platform;
using System.Runtime.CompilerServices;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e) {
		
			lbl1.Text = "3rd Year Journey\n         Reality";
			firstImage.Source = "deanmad.jpg";
	}

	private void onSecondImageClicked(object sender, EventArgs e) {
			lbl2.Text = "Life Journey\n    Reality";
			secondImage.Source = "buhol.png";
	}
	
}

