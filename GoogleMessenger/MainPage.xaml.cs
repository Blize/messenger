namespace GoogleMessenger;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void UsernameField_Completed(System.Object sender, System.EventArgs e)
    {
        string text = ((Entry)sender).Text;
        await SecureStorage.Default.SetAsync("oauth-token-username", text);
    }

    async private void GoToContactPageBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("ContactPage");
    }
}


