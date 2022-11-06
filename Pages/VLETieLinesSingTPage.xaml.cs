using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class VLETieLinesSingT1Page : VLETieLinesSingTPage
{
    public VLETieLinesSingT1Page(VLETieLinesSingTViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "TieLines Sys1";
        BindingContext = vm;
    }
}

public partial class VLETieLinesSingT2Page : VLETieLinesSingTPage
{
	public VLETieLinesSingT2Page(VLETieLinesSingTViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "TieLines Sys2";
        BindingContext = vm;
	}
}

public partial class VLETieLinesSingT3Page : VLETieLinesSingTPage
{
    public VLETieLinesSingT3Page(VLETieLinesSingTViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "TieLines Sys3";
        BindingContext = vm;
    }
}

public partial class VLETieLinesSingTPage : ContentPage
{
	VLETieLinesSingTViewModel vm;
	VLETieLinesSingTViewModel VM => vm ??= BindingContext as VLETieLinesSingTViewModel;
    public VLETieLinesSingTPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.VLETieLinesSingT.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}