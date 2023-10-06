using ScanbotSDKMVVM.Services;

namespace ScanbotSDKMVVM;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        DependencyService.Register<ScanbotSDKService>();
        InitializeSDK();

        MainPage = new AppShell();

    }

    private void InitializeSDK()
    {
        var scanbotsdkService = DependencyService.Get<ScanbotSDKService>();
        scanbotsdkService.Initialize();
    }

}

