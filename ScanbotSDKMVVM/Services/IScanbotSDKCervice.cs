using BarcodeSDK.MAUI.Models;

namespace ScanbotSDKMVVM.Services
{
    public interface IScanbotSDKCervice
	{
        void Initialize();
        Task<BarcodeResultBundle> ScanBarcode();
    }
}

