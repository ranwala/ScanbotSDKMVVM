using Android.App;
using Android.Runtime;
using BarcodeSDK.MAUI.Droid.Services;

namespace ScanbotSDKMVVM;

[Application(LargeHeap = true)]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => RegisterDependencies();

    private MauiApp RegisterDependencies()
    {
        DependencyManager.RegisterServices();
        return MauiProgram.CreateMauiApp();
    }
}