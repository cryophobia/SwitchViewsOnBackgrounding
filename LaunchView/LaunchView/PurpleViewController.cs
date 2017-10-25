using Foundation;
using System;
using UIKit;

namespace LaunchView
{
    public partial class PurpleViewController : BaseViewController
    {
        private NSObject observer;

        public PurpleViewController (IntPtr handle) : base (handle)
        {
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