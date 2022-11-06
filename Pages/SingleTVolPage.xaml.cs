using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class SingleTVol1Page : SingleTVolPage
{
    public SingleTVol1Page(SingleTVolViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Single Temperature/Volume";
        BindingContext = vm;
    }
}

public partial class SingleTVol2Page : SingleTVolPage
{
	public SingleTVol2Page(SingleTVolViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "Data 1";
        BindingContext = vm;
	}
}
public partial class SingleTVol3Page : SingleTVolPage
{
    public SingleTVol3Page(SingleTVolViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Data 2";
        BindingContext = vm;
    }
}

public partial class SingleTVol9Page : SingleTVolPage
{
    public SingleTVol9Page(SingleTVolViewModel vm) : base()
    {
        vm.Day = 9;
        Title = "Phase Env";
        BindingContext = vm;
    }
}

public partial class SingleTVolPage : ContentPage
{
	SingleTVolViewModel vm;
	SingleTVolViewModel VM => vm ??= BindingContext as SingleTVolViewModel;
    public SingleTVolPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.SingleTVol.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}