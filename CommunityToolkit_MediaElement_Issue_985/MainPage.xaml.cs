namespace CommunityToolkit_MediaElement_Issue_985;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Application.Current.MainPage.Navigation.PushAsync(new SecondaryPage());
    }
}
