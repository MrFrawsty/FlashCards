using FlashCards.Services;
using FlashCards.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	

	public MainPage()
	{
		
		InitializeComponent();

		BindingContext = ServiceHelper.GetService<SelectedTopicViewModel>();
		
	}


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}

