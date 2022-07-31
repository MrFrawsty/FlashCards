using FlashCards.Interfaces;
using FlashCards.Services;
using FlashCards.ViewModels;
using FlashCards.Views;

namespace MauiApp1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder	
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Bookerly.ttf", "bookerly");
                fonts.AddFont("Bookerly-Bold.ttf", "bookerlyBold");
				fonts.AddFont("FontAwesomeRegular.otf", "FontAwesomeRegular");
                fonts.AddFont("FontAwesomeSolid.otf", "FontAwesomeSolid");
            });

		builder.Services.AddSingleton<INoteSeparator, NoteSeparator>();
		builder.Services.AddSingleton<IFlashCardLoader, FlashCardLoader>();
		builder.Services.AddSingleton<ITopicLoader, TopicLoader>();
		builder.Services.AddSingleton<TopicsPage>();
		builder.Services.AddSingleton<TopicsViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<SelectedTopicViewModel>();


        return builder.Build();
	}
}
