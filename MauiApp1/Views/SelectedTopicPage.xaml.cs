using FlashCards.Services;
using FlashCards.ViewModels;

namespace FlashCards.Views;

public partial class SelectedTopicPage : ContentPage
{



    public SelectedTopicPage()
    {

        InitializeComponent();

        BindingContext = ServiceHelper.GetService<SelectedTopicViewModel>();

    }


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

}
