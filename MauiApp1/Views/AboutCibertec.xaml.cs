namespace MauiApp1.Views;

public partial class AboutCibertec : ContentPage
{
	public AboutCibertec()
	{
		InitializeComponent();
	}

    private async void Cibertec_Clicked(object sender, EventArgs e)
    {

            await Launcher.Default.OpenAsync("https://cibertec.edu.pe");
        

    }
}