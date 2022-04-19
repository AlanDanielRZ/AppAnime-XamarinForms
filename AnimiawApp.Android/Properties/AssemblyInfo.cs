using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AnimiawApp.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("AnimiawApp.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: Application(UsesCleartextTraffic = true)]

[assembly: UsesPermission(Android.Manifest.Permission.AccessMediaLocation)]
[assembly: UsesPermission(Android.Manifest.Permission.ManageDocuments)]
[assembly: UsesPermission(Android.Manifest.Permission.ReadExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.BindAppwidget)]
[assembly: UsesPermission(Android.Manifest.Permission.BindControls)]
[assembly: UsesPermission(Android.Manifest.Permission.BindNfcService)]
[assembly: UsesPermission(Android.Manifest.Permission.BindNotificationListenerService)]
[assembly: UsesPermission(Android.Manifest.Permission.BindQuickSettingsTile)]
[assembly: UsesPermission(Android.Manifest.Permission.BroadcastWapPush)]
[assembly: UsesPermission(Android.Manifest.Permission.Camera)]
[assembly: UsesPermission(Android.Manifest.Permission.ChangeConfiguration)]
[assembly: UsesPermission(Android.Manifest.Permission.ExpandStatusBar)]
[assembly: UsesPermission(Android.Manifest.Permission.FactoryTest)]
[assembly: UsesPermission(Android.Manifest.Permission.GetPackageSize)]
[assembly: UsesPermission(Android.Manifest.Permission.GlobalSearch)]
[assembly: UsesPermission(Android.Manifest.Permission.HardwareTest)]
[assembly: UsesPermission(Android.Manifest.Permission.InstallLocationProvider)]
[assembly: UsesPermission(Android.Manifest.Permission.InstallPackages)]
[assembly: UsesPermission(Android.Manifest.Permission.LoaderUsageStats)]
[assembly: UsesPermission(Android.Manifest.Permission.ManageDocuments)]
[assembly: UsesPermission(Android.Manifest.Permission.ManageExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.Nfc)]
[assembly: UsesPermission(Android.Manifest.Permission.NfcTransactionEvent)]
[assembly: UsesPermission(Android.Manifest.Permission.ReadExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.ReceiveWapPush)]
[assembly: UsesPermission(Android.Manifest.Permission.RequestInstallPackages)]
[assembly: UsesPermission(Android.Manifest.Permission.StatusBar)]
[assembly: UsesPermission(Android.Manifest.Permission.SystemAlertWindow)]

