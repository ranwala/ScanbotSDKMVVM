using BarcodeSDK.MAUI.Configurations;
using BarcodeSDK.MAUI.Models;

namespace ScanbotSDKMVVM.Services
{
    public class ScanbotSDKService : IScanbotSDKService
	{
        private const string LICENSE_KEY = null;

        public ScanbotSDKService()
		{
		}

        public void Initialize()
        {
            var options = new InitializationOptions
            {
                LicenseKey = LICENSE_KEY,
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
            return await BarcodeSDK.MAUI.CommonSDKServices.BarcodeService?.OpenBarcodeScannerView(configuration);
        }
    }
}

