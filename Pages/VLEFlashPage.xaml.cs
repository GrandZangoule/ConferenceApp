using Microsoft.Maui.Controls;
using MyConference.ViewModels;
using System.Diagnostics.Metrics;

namespace MyConference.Pages;

public partial class VLEFlash1Page : VLEFlashPage
{
    Button buttonGototSys2 = new Button();
    Button buttonGototSys3 = new Button();
    public VLEFlash1Page(VLEFlashViewModel vm) : base()
    {
        vm.Day = 1;
        Title = "VLE Flash";
        BindingContext = vm;
    }
    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash2";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash2Page");
    }

    private async void ToOther_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash3";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash3Page");
    }

}

public partial class VLEFlash2Page : VLEFlashPage
{
    public VLEFlash2Page(VLEFlashViewModel vm) : base()
    {
        vm.Day = 2;
        Title = "Flash 2";
        BindingContext = vm;
    }

    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash1";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash1Page");
    }

    private async void ToOther_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash3";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash3Page");
    }
}

public partial class VLEFlash3Page : VLEFlashPage
{
    Button buttonGototSys2 = new Button();
    public VLEFlash3Page(VLEFlashViewModel vm) : base()
    {
        vm.Day = 3;
        Title = "Flash 3";
        BindingContext = vm;
    }

    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash1";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash1Page");
    }

    private async void ToOther_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To Flash2";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash2Page");
    }
}

public partial class VLEFlashPage : ContentPage
{
	VLEFlashViewModel vm;
	VLEFlashViewModel VM => vm ??= BindingContext as VLEFlashViewModel;
    public VLEFlashPage()
	{		
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
         if (VM.VLEFlash.Count == 0)
            await VM.LoadDataCommand.ExecuteAsync(null);
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}

    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To FlashXX";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash2Page");
    }
    private async void ToOther_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "To FlashXXX";
        //       OnCounter_Clicked(sender, e);
        await Shell.Current.GoToAsync("//VLEFlash3Page");
    }

}