using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class VLExiyi1Page : VLExiyiPage
{
    public VLExiyi1Page(VLExiyiViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "VLE xiyi";
        BindingContext = vm;
    }
}

public partial class VLExiyi2Page : VLExiyiPage
{
	public VLExiyi2Page(VLExiyiViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "xiyi 2";
        BindingContext = vm;
	}
}

public partial class VLExiyi3Page : VLExiyiPage
{
    public VLExiyi3Page(VLExiyiViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "xiyi 3";
        BindingContext = vm;
    }
}

public partial class VLExiyiPage : ContentPage
{
    VLExiyiViewModel vm;
	VLExiyiViewModel VM => vm ??= BindingContext as VLExiyiViewModel;
    public VLExiyiPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.VLExiyi.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}