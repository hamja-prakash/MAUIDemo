using MAUISampleDemo.View;
using MAUISampleDemo.View.FieldModifier;
using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Main Page";
        CommonToolbar.ImgToolbarBack.IsVisible = false;
    }

    private async void FrmMVVMDemo_Tapped(object sender, EventArgs e)
    {
		await FrmMVVMDemo.ScaleTo(0.9, 100, Easing.Linear);
		await FrmMVVMDemo.ScaleTo(1.0, 100, Easing.Linear);
		Navigation.PushAsync(new LoginPage());
    }

    private async void FrmDeviceandAPPInfo_Tapped(object sender, EventArgs e)
    {
        await FrmDevice_APPInfo.ScaleTo(0.9, 100, Easing.Linear);
        await FrmDevice_APPInfo.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new Device_APPInfoPage());
    }

    private async void FrmFiledModifiers_Tapped(object sender, EventArgs e)
    {
        await FrmFiledModifiers.ScaleTo(0.9, 100, Easing.Linear);
        await FrmFiledModifiers.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new FieldModifierMainPage());
    }

    private async void FrmObservableProperty_Tapped(object sender, EventArgs e)
    {
        await FrmObservableProperty.ScaleTo(0.9, 100, Easing.Linear);
        await FrmObservableProperty.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new ObservablePropertyDemoPage());
    }

    private async void FrmScanner_Tapped(object sender, EventArgs e)
    {
        await FrmScanner.ScaleTo(0.9, 100, Easing.Linear);
        await FrmScanner.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new BarcodeScanner());
    }
}

