using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class SinglePVol1Page : SinglePVolPage
{
    public SinglePVol1Page(SinglePVolViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Single Pressure/Volume";
        BindingContext = vm;
    }
}

public partial class SinglePVol2Page : SinglePVolPage
{
	public SinglePVol2Page(SinglePVolViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "Data 1";
        BindingContext = vm;
	}
}
public partial class SinglePVol3Page : SinglePVolPage
{
    public SinglePVol3Page(SinglePVolViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Data 2";
        BindingContext = vm;
    }
}

public partial class SinglePVol9Page : SinglePVolPage
{
    public SinglePVol9Page(SinglePVolViewModel vm) : base()
    {
        vm.Day = 9;
        Title = "Phase Env";
        BindingContext = vm;
    }
}

public partial class SinglePVolPage : ContentPage
{
	SinglePVolViewModel vm;
	SinglePVolViewModel VM => vm ??= BindingContext as SinglePVolViewModel;
    public SinglePVolPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.SinglePVol.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}