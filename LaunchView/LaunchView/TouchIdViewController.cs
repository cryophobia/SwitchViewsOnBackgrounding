using Foundation;
using System;
using UIKit;
using LocalAuthentication;

namespace LaunchView
{
    public partial class TouchIdViewController : UIViewController
    {
        public TouchIdViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated) {
            base.ViewDidAppear(animated);
        }

        public void AuthenticateMe(){
            var context = new LAContext();
            NSError AuthError;
            var myReason = new NSString("Log in to proceed");


            if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError)) {
                var replyHandler = new LAContextReplyHandler((success, error) => {

                    this.InvokeOnMainThread(() => {
                        if (success) {
                            Console.WriteLine("You logged in!");
                            UIApplication.SharedApplication.KeyWindow.RootViewController = AppDelegate.CachedViewController;
                        } else {
                            //Show fallback mechanism here
                        }
                    });
                });
                context.EvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, myReason, replyHandler);
            };
        }
    }
}