namespace MAUISampleDemo.View.FieldModifier;

public partial class CommonToolbarView : ContentView
{
	public CommonToolbarView()
	{
		InitializeComponent();
	}

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}