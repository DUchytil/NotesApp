using MyMobileApp.ViewModel;

namespace MyMobileApp;

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
			});

        //Singleton is like a "global" where it creates one copy of the page that will be kept in memory
		//Registering page with the dependency service
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();


        return builder.Build();
	}
}
