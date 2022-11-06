using Microsoft.Maui.Controls;
using MyConference.ViewModels;
namespace MyConference.Pages;

public partial class ScheduleDay1Page : SchedulePage
{
    public ScheduleDay1Page(ScheduleViewModel vm) : base()
    {
        object sender = new object();
        EventArgs e = new EventArgs();

        vm.Day = 1;
        Title = "Schedule - Day 1";
        BindingContext = vm;

    }

    private void OnCounter_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//SingleComp3Page");
        Shell.Current.GoToAsync("//SingleComp2Page");
        Shell.Current.GoToAsync("//SingleComp1Page");
        Shell.Current.GoToAsync("//SingleTVol3Page");
        Shell.Current.GoToAsync("//SingleTVol2Page");
        Shell.Current.GoToAsync("//SingleTVol1Page");
        Shell.Current.GoToAsync("//SinglePVol3Page");
        Shell.Current.GoToAsync("//SinglePVol2Page");
        Shell.Current.GoToAsync("//SinglePVol1Page");
 
        Shell.Current.GoToAsync("//BinaryCalcs4Page");
        Shell.Current.GoToAsync("//BinaryCalcs3Page");
        Shell.Current.GoToAsync("//BinaryCalcs2Page");
        Shell.Current.GoToAsync("//BinaryCalcs1Page");
        Shell.Current.GoToAsync("//BinMcCabe3Page");
        Shell.Current.GoToAsync("//BinMcCabe2Page");
        Shell.Current.GoToAsync("//BinMcCabe1Page");
        Shell.Current.GoToAsync("//BinActModel3Page");
        Shell.Current.GoToAsync("//BinActModel2Page");
        Shell.Current.GoToAsync("//BinActModel1Page");

        Shell.Current.GoToAsync("//VLEFlash3Page");
        Shell.Current.GoToAsync("//VLEFlash2Page");
        Shell.Current.GoToAsync("//VLEFlash1Page");
        Shell.Current.GoToAsync("//VLExiyi3Page");
        Shell.Current.GoToAsync("//VLExiyi2Page");
        Shell.Current.GoToAsync("//VLExiyi1Page");

        Shell.Current.GoToAsync("//VLETieLinesSingT3Page");
        Shell.Current.GoToAsync("//VLETieLinesSingT2Page");
        Shell.Current.GoToAsync("//VLETieLinesSingT1Page");
        Shell.Current.GoToAsync("//VLETieLinesSingP3Page");
        Shell.Current.GoToAsync("//VLETieLinesSingP2Page");
        Shell.Current.GoToAsync("//VLETieLinesSingP1Page"); 
        Shell.Current.GoToAsync("//VLETieLinesMultT3Page");
        Shell.Current.GoToAsync("//VLETieLinesMultT2Page");
        Shell.Current.GoToAsync("//VLETieLinesMultT1Page"); 
        Shell.Current.GoToAsync("//VLETieLinesMultP3Page");
        Shell.Current.GoToAsync("//VLETieLinesMultP2Page");
        Shell.Current.GoToAsync("//VLETieLinesMultP1Page");
        Shell.Current.GoToAsync("//ScheduleDay2Page");

    }

}

public partial class ScheduleDay2Page : SchedulePage
{
	public ScheduleDay2Page(ScheduleViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "Schedule - Day 2";
        BindingContext = vm;
	}

    private void OnCounter_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ScheduleDay3Page");

    }

}

public partial class ScheduleDay3Page : SchedulePage
{
    public ScheduleDay3Page(ScheduleViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Schedule - Day 3";
        BindingContext = vm;
    }

    private void OnCounter_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ScheduleDay1Page");

    }

}

public partial class SchedulePage : ContentPage
{
	ScheduleViewModel vm;
	ScheduleViewModel VM => vm ??= BindingContext as ScheduleViewModel; 
    public SchedulePage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();

        if (VM.Schedule.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);

    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

    private void OnCounter_Clicked(object sender, EventArgs e)
    {

    }
}