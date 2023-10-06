using System.Collections.ObjectModel;
using BarcodeSDK.MAUI.Models;
using ScanbotSDKMVVM.Models;
using ScanbotSDKMVVM.Services;

namespace ScanbotSDKMVVM.ViewModels
{
    public class MainPageViewModel : BaseViewModel
	{
        private ScanbotSDKService scanbotsdkService;

        public Command DocumentScanCommand { get; }
        public Command ClearResultCommand { get; }

        public ObservableCollection<BarcodeModel> BarcodeList { get; set; }

        public MainPageViewModel()
        {
            scanbotsdkService = DependencyService.Get<ScanbotSDKService>();
            BarcodeList = new ObservableCollection<BarcodeModel>();
            DocumentScanCommand = new Command(OnScanClicked);
            ClearResultCommand = new Command(OnClearClicked);
        }

        private async void OnScanClicked()
        {
            BarcodeResultBundle response = await scanbotsdkService.ScanBarcode();
            GenerateBarcodeList(response.Barcodes);
        }

        private void OnClearClicked(object obj)
        {
            BarcodeList?.Clear();
        }

        private void GenerateBarcodeList(List<Barcode> barcodes)
        {
            foreach (var barcode in barcodes)
            {
                var barcodeModel = new BarcodeModel
                {
                    BarcodeFormat = barcode.Format.ToString(),
                    BarcodeText = barcode.Text
                };

                BarcodeList.Add(barcodeModel);
            }
        }
    }
}