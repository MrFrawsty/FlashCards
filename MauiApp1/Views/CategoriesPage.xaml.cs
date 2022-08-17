using FlashCards.Services;
using FlashCards.ViewModels;

namespace FlashCards.Views;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage()
	{
		InitializeComponent();
		BindingContext = ServiceHelper.GetService<CategoriesViewModel>();
	}
}