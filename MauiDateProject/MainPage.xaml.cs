using System.Globalization;

namespace MauiDateProject;

public partial class MainPage : ContentPage
{
    private bool _isBouncingRight = true;
    private int BounceCount = 0;
    public MainPage()
	{
		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        
        if ((Button)sender == SundayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelSunday);
            TextToSpeech.SpeakAsync(FranceLabelSunday.Text);
            
        }
        else if ((Button)sender == MondayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelMonday);
            TextToSpeech.SpeakAsync(FranceLabelMonday.Text);
        }
        if ((Button)sender == TuesdayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelTuesday);
            TextToSpeech.SpeakAsync(FranceLabelTuesday.Text);
        }
        else if ((Button)sender == WednesdayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelWednesday);
            TextToSpeech.SpeakAsync(FranceLabelWednesday.Text);
        }
        if ((Button)sender == ThursdayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelThursday);
            TextToSpeech.SpeakAsync(FranceLabelThursday.Text);
        }
        else if ((Button)sender == FridayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelFriday);
            TextToSpeech.SpeakAsync(FranceLabelFriday.Text);
        }
        else if ((Button)sender == SaturdayFranceButton)
        {
            BounceCount = 0;
            StartBounceAnimation(FranceLabelSaturday);
            TextToSpeech.SpeakAsync(FranceLabelSaturday.Text);
        }
        if ((Button)sender == SundayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelSunday);
            TextToSpeech.SpeakAsync(GermanyLabelSunday.Text);
        }
        else if ((Button)sender == MondayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelMonday);
            TextToSpeech.SpeakAsync(GermanyLabelMonday.Text);
        }
        if ((Button)sender == TuesdayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelTuesday);
            TextToSpeech.SpeakAsync(GermanyLabelTuesday.Text);
        }
        else if ((Button)sender == WednesdayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelWednesday);
            TextToSpeech.SpeakAsync(GermanyLabelWednesday.Text);
        }
        if ((Button)sender == ThursdayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelThursday);
            TextToSpeech.SpeakAsync(GermanyLabelThursday.Text);
        }
        else if ((Button)sender == FridayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelFriday);
            TextToSpeech.SpeakAsync(GermanyLabelFriday.Text);
        }
        else if ((Button)sender == SaturdayGermanyButton)
        {
            BounceCount = 0;
            StartBounceAnimation(GermanyLabelSaturday);
            TextToSpeech.SpeakAsync(GermanyLabelSaturday.Text);
        }
    }

    private async void StartBounceAnimation(Label _label)
    {
        await _label.TranslateTo(100, 0, 1000, Easing.SinInOut);

        //while (true)
        //{
        //    if (_isBouncingRight)
        //    {
        //        await _label.TranslateTo(Application.Current.MainPage.Width - _label.Width, 0, 1000, Easing.SinInOut);
        //    }
        //    else
        //    {
        //        await _label.TranslateTo(0, 0, 1000, Easing.SinInOut);
        //    }

        //    _isBouncingRight = !_isBouncingRight;
        //}
    }

}

