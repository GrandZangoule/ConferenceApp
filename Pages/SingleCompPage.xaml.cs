using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class SingleComp1Page : SingleCompPage
{
    public SingleComp1Page(SingleCompViewModel vm) : base()
    {

        vm.Day = 1;
        Title = "Single Pressure/Temperature";
        BindingContext = vm;

        var page = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
        // Remove old page
        Navigation.RemovePage(page);

    }
}

public partial class SingleComp2Page : SingleCompPage
{
	public SingleComp2Page(SingleCompViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "Data 1";
        BindingContext = vm;
 
        var page = Navigation.NavigationStack.LastOrDefault();
        // Remove old page
        Navigation.RemovePage(page);
    }
}
public partial class SingleComp3Page : SingleCompPage
{
    public SingleComp3Page(SingleCompViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Data 2";
        BindingContext = vm;

        var page = Navigation.NavigationStack.LastOrDefault();
        // Remove old page
        Navigation.RemovePage(page);
    }
}

public partial class SingleComp9Page : SingleCompPage
{
    public SingleComp9Page(SingleCompViewModel vm) : base()
    {
        vm.Day = 9;
        Title = "Phase Env";
        BindingContext = vm;
    }
}

public partial class SingleCompPage : ContentPage
{
	SingleCompViewModel vm;
	SingleCompViewModel VM => vm ??= BindingContext as SingleCompViewModel;
    public SingleCompPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.SingleComp.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}