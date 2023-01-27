using ZXing;

namespace MAUISampleDemo.View;

public partial class BarcodeScanner : ContentPage
{
	public BarcodeScanner()
	{
		InitializeComponent();
        //barcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions()
        //{
        //    Formats = ZXing.Net.Maui.BarcodeFormat.QrCode | ZXing.Net.Maui.BarcodeFormat.Aztec
        //};
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            barcodeResult.Text = (!string.IsNullOrEmpty(e.Results[0].Value)) ? e.Results[0].Value : string.Empty;
            barcodeType.Text = (!string.IsNullOrEmpty(e.Results[0].Format.ToString())) ? e.Results[0].Format.ToString() : string.Empty;
        });
    }
}