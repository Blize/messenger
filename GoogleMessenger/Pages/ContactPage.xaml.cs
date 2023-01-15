using System.Collections.ObjectModel;

namespace GoogleMessenger.Pages;

public partial class ContactPage : ContentPage
{

    //ALL the comments you see was an Idea of Dynamic Contact Filling. Sadly it didnt worked and I had to use hardcoded code

    // public ObservableCollection<User> Contact { get; set; } = new ObservableCollection<User>();
    // public List<User> UserList { get; set; }
    public ContactPage()
    {
        InitializeComponent();
      //  BindingContext = this;

    }
    /*
    protected override void OnAppearing()
    {
        UserList = new List<User>()
        {
            new User() {Username = "Annika", Email = "annika@mantsch.com", LastMessage = "Super! machen wir so...", ImageSource = "dotnet_bot.jpg"},
            new User() {Username = "Jan", Email = "jan@mantsch.com", LastMessage = "Klar, bin in 10min da...", ImageSource = "dotnet_bot.jpg.jpg"},

        };


        if (!UserList.Any())
        {
            foreach (var user in UserList)
            {
                var userCopy = user;
                Contact.Add(userCopy);
            }
        }
        base.OnAppearing();
    }
    */

    async void GoToChatPage_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("ChatPage");
    }

    async void GoToSettings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("SettingsPage");
    }
}
