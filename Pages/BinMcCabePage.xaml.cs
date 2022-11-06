using Microsoft.Maui.Controls;
using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class BinMcCabe1Page : BinMcCabePage
{
    public BinMcCabe1Page(BinMcCabeViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "McCabeThiele Auto";
        BindingContext = vm;
    }
}

public partial class BinMcCabe2Page : BinMcCabePage
{
	public BinMcCabe2Page(BinMcCabeViewModel vm) : base()
	{
        vm.Day = 2;
        Title = "McCabeThiele Eqn";
        BindingContext = vm;
    }
}

public partial class BinMcCabe3Page : BinMcCabePage
{
    public BinMcCabe3Page(BinMcCabeViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "McCabeThiele Man";
        BindingContext = vm;
    }
}

public partial class BinMcCabePage : ContentPage
{
	BinMcCabeViewModel vm;
	BinMcCabeViewModel VM => vm ??= BindingContext as BinMcCabeViewModel;
    public BinMcCabePage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
         if (VM.BinMcCabe.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

}