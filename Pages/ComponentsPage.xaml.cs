using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class ComponentsPage2 : ContentPage
{
    int MyCounter = 0;
	public ComponentsPage2()
	{
		InitializeComponent();
	}

    private async void OnCounter_Clicked(object sender, EventArgs e)
    {
        MyCounter++;
        if (MyCounter==1)
            await Shell.Current.GoToAsync("//VLEFlash1Page");
        else if (MyCounter == 2)
            await Shell.Current.GoToAsync("//VLEFlash2Page");
        else
            await Shell.Current.GoToAsync("//VLEFlash3Page");

        if (MyCounter == 3)
            MyCounter = 0;
        OnCounter.Text= MyCounter.ToString();

    }
}