using BarcodeSDK.MAUI.Models;

namespace ScanbotSDKMVVM.Services
{
    public interface IScanbotSDKService
	{
        void Initialize();
        Task<BarcodeResultBundle> ScanBarcode();
    }
}