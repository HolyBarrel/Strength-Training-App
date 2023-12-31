﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Http;
using StrengthTrainingApp.Services.Implementations;
using StrengthTrainingApp.Services.Interfaces;

namespace StrengthTrainingApp;

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
			});

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddSingleton<IAuthService, AuthService>();
		builder.Services.AddSingleton<IFullWorkoutService, FullWorkoutService>();
        builder.Services.AddSingleton<ISetService, SetService>();
        builder.Services.AddSingleton<IExerciseService, ExerciseService>();
        builder.Services.AddSingleton<IWorkoutService, WorkoutService>();
        builder.Services.AddSingleton<IExerciseTypeService, ExerciseTypeService>();
        builder.Services.AddHttpClient();
        builder.Services.AddSingleton(SecureStorage.Default);

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
