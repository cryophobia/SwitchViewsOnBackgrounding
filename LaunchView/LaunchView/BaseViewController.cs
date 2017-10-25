using System;
using Foundation;
using UIKit;

namespace LaunchView {
    public class BaseViewController : UIViewController{

        private NSObject observer;

        public BaseViewController(IntPtr handle) : base (handle)
        {
        }

        public Action<NSNotification> DefaultsScreenChanged { get; private set; }

        public void Initialize() {
            DefaultsScreenChanged = (obj) => {
                AppDelegate.CachedViewController = UIApplication.SharedApplication.KeyWindow.RootViewController;
                UIApplication.SharedApplication.KeyWindow.RootViewController = this.Storyboard.InstantiateViewController("TouchIdViewControllerId");
            };
        }

        public void Subscribe() {
            observer = NSNotificationCenter.DefaultCenter.AddObserver((NSString)"ExchangeWithTouchIdViewController", DefaultsScreenChanged);
        }

        public void UnSubscribe() {
            NSNotificationCenter.DefaultCenter.RemoveObserver(observer);
        }
    }
}
