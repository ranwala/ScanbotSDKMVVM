using Android.App;
using Android.Runtime;

namespace ScanbotSDKMVVM;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override void OnCreate()
    {
        base.OnCreate();

        BarcodeSDK.MAUI.Droid.Services.DependencyManager.RegisterServices();
    }
}

