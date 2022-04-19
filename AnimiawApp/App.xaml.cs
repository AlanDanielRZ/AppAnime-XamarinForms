using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;
using Com.OneSignal.Abstractions;
using System.Collections.Generic;

namespace AnimiawApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Email"))
                MainPage = new NavigationPage(new MainPage());
            else
                MainPage = new NavigationPage(new Login());


            OneSignal.Current.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

            OneSignal.Current.StartInit("66fc73ea-9485-450f-afb6-b8413b9d6e85")
            .Settings(new Dictionary<string, bool>() {
            { IOSSettings.kOSSettingsKeyAutoPrompt, false },
            { IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
            .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            .EndInit();

            // The promptForPushNotificationsWithUserResponse function will show the iOS push notification prompt. We recommend removing the following code and instead using an In-App Message to prompt for notification permission (See step 7)
            OneSignal.Current.RegisterForPushNotifications();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
