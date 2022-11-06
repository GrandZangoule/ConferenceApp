using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class BinActModel1Page : BinActModelPage
{
    public BinActModel1Page(BinActModelViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Wilson";
        BindingContext = vm;
    }
}

public partial class BinActModel2Page : BinActModelPage
{
	public BinActModel2Page(BinActModelViewModel vm) : base()
	{
        vm.Day = 2;
        Title = "NRTL";
        BindingContext = vm;
    }
}

public partial class BinActModel3Page : BinActModelPage
{
    public BinActModel3Page(BinActModelViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "UNIQUAC";
        BindingContext = vm;
    }
}

public partial class BinActModelPage : ContentPage
{
	BinActModelViewModel vm;
	BinActModelViewModel VM => vm ??= BindingContext as BinActModelViewModel;
    public BinActModelPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
         if (VM.BinActModel.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}