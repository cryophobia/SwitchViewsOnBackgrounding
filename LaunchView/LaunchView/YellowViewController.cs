using Foundation;
using System;
using UIKit;

namespace LaunchView  
{
    public partial class YellowViewController : BaseViewController
    {
        public YellowViewController (IntPtr handle) : base (handle)
        {
        }

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