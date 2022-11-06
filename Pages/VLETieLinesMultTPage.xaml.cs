using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class VLETieLinesMultT1Page : VLETieLinesMultTPage
{
    public VLETieLinesMultT1Page(VLETieLinesMultTViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "TieLines Mult-T";
        BindingContext = vm;
    }
}

public partial class VLETieLinesMultT2Page : VLETieLinesMultTPage
{
	public VLETieLinesMultT2Page(VLETieLinesMultTViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "TieLines Mult-T";
        BindingContext = vm;
	}
}

public partial class VLETieLinesMultT3Page : VLETieLinesMultTPage
{
    public VLETieLinesMultT3Page(VLETieLinesMultTViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "TieLines Mult-T";
        BindingContext = vm;
    }
}

public partial class VLETieLinesMultTPage : ContentPage
{
    VLETieLinesMultTViewModel vm;
	VLETieLinesMultTViewModel VM => vm ??= BindingContext as VLETieLinesMultTViewModel;
    public VLETieLinesMultTPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.VLETieLinesMultT.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}