using ControlStudentsPayment.Data;
using ControlStudentsPayment.ViewModels;
using ControlStudentsPayment.Views;
using Microsoft.Extensions.Logging;

namespace ControlStudentsPayment;

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
                fonts.AddFont("fa-brands-400.ttf", "FAB");
                fonts.AddFont("fa-regular-400.ttf", "FAR");
                fonts.AddFont("fa-solid-900.ttf", "FAS");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<DatabaseContext>();

        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<CashViewModel>();
        builder.Services.AddTransient<SearchStudentsViewModel>();

        builder.Services.AddTransient<HomeView>();
		builder.Services.AddTransient<CashView>();
		builder.Services.AddTransient<SearchStudentsView>();

        return builder.Build();
	}
}
