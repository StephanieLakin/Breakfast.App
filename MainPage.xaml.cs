using BreakfastApp.ViewModels;

namespace BreakfastApp;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new BreakfastViewModel();
	}

	
}

