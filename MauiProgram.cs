using MyConference.Pages;
using MyConference.ViewModels;

namespace MyConference;

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


        builder.Services.AddSingleton<ScheduleDay1Page>();
        builder.Services.AddSingleton<ScheduleDay2Page>();
        builder.Services.AddSingleton<ScheduleDay3Page>();
        builder.Services.AddTransient<ScheduleViewModel>();
        builder.Services.AddSingleton<SingleComp1Page>();
        builder.Services.AddSingleton<SingleComp2Page>();
        builder.Services.AddSingleton<SingleComp3Page>();
        builder.Services.AddSingleton<SingleComp9Page>();
        builder.Services.AddTransient<SingleCompViewModel>();
        builder.Services.AddSingleton<SingleTVol1Page>();
        builder.Services.AddSingleton<SingleTVol2Page>();
        builder.Services.AddSingleton<SingleTVol3Page>();
        builder.Services.AddTransient<SingleTVolViewModel>();
        builder.Services.AddSingleton<SinglePVol1Page>();
        builder.Services.AddSingleton<SinglePVol2Page>();
        builder.Services.AddSingleton<SinglePVol3Page>();
        builder.Services.AddTransient<SinglePVolViewModel>();
        builder.Services.AddSingleton<BinaryCalcs1Page>();
        builder.Services.AddSingleton<BinaryCalcs2Page>();
        builder.Services.AddSingleton<BinaryCalcs3Page>();
        builder.Services.AddSingleton<BinaryCalcs4Page>();
        builder.Services.AddTransient<BinaryCalcsViewModel>();
        builder.Services.AddSingleton<BinMcCabe1Page>();
        builder.Services.AddSingleton<BinMcCabe2Page>();
        builder.Services.AddSingleton<BinMcCabe3Page>();
        builder.Services.AddTransient<BinMcCabeViewModel>();
        builder.Services.AddSingleton<BinActModel1Page>();
        builder.Services.AddSingleton<BinActModel2Page>();
        builder.Services.AddSingleton<BinActModel3Page>();
        builder.Services.AddTransient<BinActModelViewModel>();
        builder.Services.AddTransient<VLEFlash1Page>();
        builder.Services.AddTransient<VLEFlash2Page>();
        builder.Services.AddTransient<VLEFlash3Page>();
        builder.Services.AddTransient<VLEFlashViewModel>();
        builder.Services.AddSingleton<VLExiyi1Page>();
        builder.Services.AddSingleton<VLExiyi2Page>();
        builder.Services.AddSingleton<VLExiyi3Page>();
        builder.Services.AddTransient<VLExiyiViewModel>();
        builder.Services.AddSingleton<SingleComp1Page>();
        builder.Services.AddSingleton<SingleComp2Page>();
        builder.Services.AddSingleton<SingleComp3Page>();
        builder.Services.AddSingleton<SingleComp9Page>();
        builder.Services.AddTransient<SingleCompViewModel>();
        builder.Services.AddSingleton<VLETieLinesSingT1Page>();
        builder.Services.AddSingleton<VLETieLinesSingP1Page>();
        builder.Services.AddSingleton<VLETieLinesSingT2Page>();
        builder.Services.AddSingleton<VLETieLinesSingP2Page>();
        builder.Services.AddSingleton<VLETieLinesSingT3Page>();
        builder.Services.AddSingleton<VLETieLinesSingP3Page>();
        builder.Services.AddSingleton<VLETieLinesSingTViewModel>();
        builder.Services.AddSingleton<VLETieLinesSingPViewModel>();
        builder.Services.AddSingleton<VLETieLinesMultT1Page>();
        builder.Services.AddSingleton<VLETieLinesMultP1Page>();
        builder.Services.AddSingleton<VLETieLinesMultT2Page>();
        builder.Services.AddSingleton<VLETieLinesMultP2Page>();
        builder.Services.AddSingleton<VLETieLinesMultT3Page>();
        builder.Services.AddSingleton<VLETieLinesMultP3Page>();
        builder.Services.AddSingleton<VLETieLinesMultTViewModel>();
        builder.Services.AddSingleton<VLETieLinesMultPViewModel>();
        

        return builder.Build();
	}
}
