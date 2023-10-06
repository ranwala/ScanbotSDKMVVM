using ScanbotSDKMVVM.ViewModels;

namespace ScanbotSDKMVVM;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();
	}
}


