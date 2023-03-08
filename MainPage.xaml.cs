namespace Schueler_Noten_System_MAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void hinzufügen_button_deutsch_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("addPage");
	}
}