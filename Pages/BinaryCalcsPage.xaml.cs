using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class BinaryCalcs1Page : BinaryCalcsPage
{
    public BinaryCalcs1Page(BinaryCalcsViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "Binary Single Temperature";
        BindingContext = vm;
    }
}

public partial class BinaryCalcs2Page : BinaryCalcsPage
{
	public BinaryCalcs2Page(BinaryCalcsViewModel vm) : base()
	{
		vm.Day = 2;
        Title = "Binary Single Pressure";
        BindingContext = vm;
	}
}
public partial class BinaryCalcs3Page : BinaryCalcsPage
{
    public BinaryCalcs3Page(BinaryCalcsViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Binary Multiple Temperature";
        BindingContext = vm;
    }
}
public partial class BinaryCalcs4Page : BinaryCalcsPage
{
    public BinaryCalcs4Page(BinaryCalcsViewModel vm) : base()
    {
        vm.Day = 4;
        Title = "Binary Multiple Pressure";
        BindingContext = vm;
    }
}

public partial class BinaryCalcsPage : ContentPage
{
	BinaryCalcsViewModel vm;
	BinaryCalcsViewModel VM => vm ??= BindingContext as BinaryCalcsViewModel;
    public BinaryCalcsPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.BinaryCalcs.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}