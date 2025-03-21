using GarageManagerMAIU.Pages;
using Microsoft.Extensions.Logging;

namespace GarageManagerMAIU;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<OrdemServicoPage>();
		builder.Services.AddTransient<LoginPage>();

		builder.Services.AddScoped<LoginViewModel>();

        return builder.Build();
	}
}
