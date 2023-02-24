namespace ManufacturerFinder;

public partial class MainPage : ContentPage
{
    readonly MainPageViewModel ViewModel;

    public MainPage()
	{
        ViewModel = new MainPageViewModel();
        this.BindingContext = ViewModel;
        InitializeComponent();
	}
}