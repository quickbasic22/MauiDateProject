using System.Globalization;

namespace MauiDateProject;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        
        if ((Button)sender == FranceButton)
        {
            TextToSpeech.SpeakAsync(FranceLabel.Text);
        }
        else if ((Button)sender == GermanyButton)
        {
            TextToSpeech.SpeakAsync(GermanyLabel.Text);
        }
    }
}

