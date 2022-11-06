using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class VLETieLinesSingP1Page : VLETieLinesSingPPage
{
    public VLETieLinesSingP1Page(VLETieLinesSingPViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "TieLines Sys1";
        BindingContext = vm;
    }
}

public partial class VLETieLinesSingP2Page : VLETieLinesSingPPage
{
	public VLETieLinesSingP2Page(VLETieLinesSingPViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "TieLines Sys2";
        BindingContext = vm;
	}
}

public partial class VLETieLinesSingP3Page : VLETieLinesSingPPage
{
    public VLETieLinesSingP3Page(VLETieLinesSingPViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "TieLines Sys3";
        BindingContext = vm;
    }
}

public partial class VLETieLinesSingPPage : ContentPage
{
	VLETieLinesSingPViewModel vm;
	VLETieLinesSingPViewModel VM => vm ??= BindingContext as VLETieLinesSingPViewModel;
    public VLETieLinesSingPPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.VLETieLinesSingP.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}