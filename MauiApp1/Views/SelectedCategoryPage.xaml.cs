using FlashCards.Services;
using FlashCards.ViewModels;

namespace FlashCards.Views;

public partial class SelectedCategoryPage : ContentPage
{
	public SelectedCategoryPage()
	{
		InitializeComponent();
		BindingContext = ServiceHelper.GetService<SelectedCategoryViewModel>();
	}
}