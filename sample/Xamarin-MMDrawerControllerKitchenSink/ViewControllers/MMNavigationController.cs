using System;
using MonoTouch.UIKit;

using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMNavigationController : UINavigationController
	{
		public MMNavigationController(){
			this.Init ();
		}

		public MMNavigationController(UIViewController rootViewController){
			base.AddChildViewController (rootViewController);
		}

		public override UIStatusBarStyle PreferredStatusBarStyle ()
		{
			return base.PreferredStatusBarStyle ();
			if (MMDrawerController_UIViewController.Mm_drawerController.ShowsStatusBarBackgroundView) {
				return UIStatusBarStyle.LightContent;
			} else {
				return UIStatusBarStyle.Default;
			}
		}
	}
}

