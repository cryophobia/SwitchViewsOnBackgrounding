using Foundation;
using System;
using UIKit;

namespace LaunchView
{
    public partial class RedViewController : BaseViewController
    {
        private NSObject observer;

        public RedViewController (IntPtr handle) : base (handle)
        {
        }

        public Action<NSNotification> DefaultsScreenChanged { get; private set; }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            base.Initialize();
        }

        public override void ViewWillAppear(bool animated) {
            base.Subscribe();
        }

        public override void ViewWillDisappear(bool animated) {
            base.UnSubscribe();
        }
    }
}