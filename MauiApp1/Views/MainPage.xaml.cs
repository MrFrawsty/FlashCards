using FlashCards.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	MainViewModel mainViewModel;

	public MainPage()
	{
		
		InitializeComponent();

		BindingContext = mainViewModel = new MainViewModel();
		
	}

	


}

