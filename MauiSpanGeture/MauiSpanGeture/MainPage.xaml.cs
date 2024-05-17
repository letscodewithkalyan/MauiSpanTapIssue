namespace MauiSpanGeture;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await App.Current.MainPage.DisplayAlert(string.Empty, "Arabic Text tapped", "Ok");
    }

    async void EnglishGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await App.Current.MainPage.DisplayAlert(string.Empty, "English Text tapped", "Ok");
    }
}


