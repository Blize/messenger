namespace GoogleMessenger;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("ContactPage", typeof(Pages.ContactPage));
		Routing.RegisterRoute("ChatPage", typeof(Pages.ChatPage));
		Routing.RegisterRoute("SettingsPage", typeof(Pages.SettingsPage));
		Routing.RegisterRoute("AdvancedSettings", typeof(Pages.AdvancedSettings));
	}

}

