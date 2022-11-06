using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class VLETieLinesMultP1Page : VLETieLinesMultPPage
{
    public VLETieLinesMultP1Page(VLETieLinesMultPViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "TieLines P-Mult Sys1";
        BindingContext = vm;
    }
}

public partial class VLETieLinesMultP2Page : VLETieLinesMultPPage
{
	public VLETieLinesMultP2Page(VLETieLinesMultPViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "TieLines P-Mult Sys2";
        BindingContext = vm;
	}
}

public partial class VLETieLinesMultP3Page : VLETieLinesMultPPage
{
    public VLETieLinesMultP3Page(VLETieLinesMultPViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "TieLines P-Mult Sys3";
        BindingContext = vm;
    }
}

public partial class VLETieLinesMultPPage : ContentPage
{
	VLETieLinesMultPViewModel vm;
	VLETieLinesMultPViewModel VM => vm ??= BindingContext as VLETieLinesMultPViewModel;
    public VLETieLinesMultPPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.VLETieLinesMultP.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}