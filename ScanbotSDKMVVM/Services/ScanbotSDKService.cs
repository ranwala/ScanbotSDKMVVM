using BarcodeSDK.MAUI.Configurations;
using BarcodeSDK.MAUI.Models;

namespace ScanbotSDKMVVM.Services
{
    public class ScanbotSDKService : IScanbotSDKCervice
	{
		public ScanbotSDKService()
		{
		}

        public void Initialize()
        {
            var options = new InitializationOptions
            {
                LicenseKey = null,
                LoggingEnabled = true,
                ErrorHandler = (status, feature) =>
                {
                    Console.WriteLine($"License error: {status}, {feature}");
                }
            };
            BarcodeSDK.MAUI.ScanbotBarcodeSDK.Initialize(options);
        }

        public async Task<BarcodeResultBundle> ScanBarcode()
        {
            var configuration = new BarcodeScannerConfiguration();
            return await BarcodeSDK.MAUI.ScanbotBarcodeSDK.BarcodeService?.OpenBarcodeScannerView(configuration);
        }
    }
}

