namespace GoogleMessenger.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    async void GoToAdvancedSettings(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync("AdvancedSettings");
    }
}
