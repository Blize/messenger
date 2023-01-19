using System.Collections.ObjectModel;

namespace GoogleMessenger.Pages;

public partial class ContactPage : ContentPage
{

    readonly IList<User> source;
    public ObservableCollection<User> Contact { get; private set; }

    public ContactPage()
    {
        InitializeComponent();
        source = new List<User>();
        CreateUserCollection();

        BindingContext = this;

    }

    private void CreateUserCollection()
    {
        source.Add(new User() { Username = "Annika", Email = "annika@something.com", LastMessage = "Klar! Freut mich...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Jan", Email = "jan@something.com", LastMessage = "Okay. Bin in 10min da...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Joel", Email = "joel@something.com", LastMessage = "Lol hahahah...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Julian", Email = "julian@something.com", LastMessage = "Bitte was??...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Peter", Email = "peter@something.com", LastMessage = "Cool! Musst du unbedingt...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Adel", Email = "adel@something.com", LastMessage = "nice hahaha, wm gad?...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Tabea", Email = "tabea@something.com", LastMessage = "Habe essen mitgebracht...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Yan", Email = "yan@something.com", LastMessage = "bi gad am volleyball spiele", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Robin", Email = "robin@something.com", LastMessage = "Jo bi gad are home", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Noel", Email = "noel@something.com", LastMessage = "ok chöi mr mache...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Gwendolin", Email = "gwendolin@something.com", LastMessage = "Bin gerade im Museum...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Zocken", Email = "null", LastMessage = "Komme in 5min on", ImageSource = "dotnet_bot.png", GroupChat = true });
        source.Add(new User() { Username = "Sarina", Email = "sarina@something.com", LastMessage = "merci!...", ImageSource = "dotnet_bot.png", GroupChat = false });
        source.Add(new User() { Username = "Timo", Email = "timo@something.com", LastMessage = "sorry bi ide ferie", ImageSource = "dotnet_bot.png", GroupChat = false });

        Contact = new ObservableCollection<User>(source);
    }


    async void GoToChatPage_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("ChatPage");
    }

    async void GoToSettings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("SettingsPage");
    }
}
