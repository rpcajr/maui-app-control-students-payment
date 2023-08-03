using CommunityToolkit.Maui;
using ControlStudentsPayment.Data;
using ControlStudentsPayment.Services;
using ControlStudentsPayment.ViewModels;
using ControlStudentsPayment.ViewModels.Students;
using ControlStudentsPayment.Views;
using ControlStudentsPayment.Views.Students;
using Microsoft.Extensions.Logging;

namespace ControlStudentsPayment;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
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
		builder.Services.AddSingleton<StudentService>();

        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<CashViewModel>();
        builder.Services.AddTransient<SearchStudentsViewModel>();
        builder.Services.AddTransient<AddStudentsViewModel>();

        builder.Services.AddTransient<HomeView>();
		builder.Services.AddTransient<CashView>();
		builder.Services.AddTransient<SearchStudentsView>();
		builder.Services.AddTransient<AddStudentsView>();

        return builder.Build();
	}
}
