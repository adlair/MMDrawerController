	using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIResponder, IUIApplicationDelegate
	{
		// class-level declarations

		public MMDrawerController.MMDrawerController DrawerController {
			get;
			set;
		}

		public  UIWindow Window {
			get;
			set;
		}

		[Export("application:willFinishLaunchingWithOptions:")]
		public virtual bool WillFinishLaunching (UIApplication application, MonoTouch.Foundation.NSDictionary launchOptions){
			UIViewController leftSideDrawerViewController = new MMExampleLeftSideDrawerViewController ();
			UIViewController centerViewController = new MMExampleCenterTableViewController ();
			UIViewController rightSideDrawerViewController = new UIViewController ();// new MMExampleRightSideDrawerViewController ();

			UINavigationController navigationController = new MMNavigationController ();
			navigationController.ViewControllers = new UIViewController[]{ centerViewController };
			navigationController.RestorationIdentifier = "MMExampleCenterNavigationControllerRestorationKey";

			UINavigationController leftSideNavController = new MMNavigationController ();
			leftSideNavController.ViewControllers = new UIViewController[]{ leftSideDrawerViewController };
			leftSideNavController.RestorationIdentifier = "MMExampleLeftNavigationControllerRestorationKey";

			this.DrawerController = new MMDrawerController.MMDrawerController ();
			DrawerController.CenterViewController = navigationController;
			DrawerController.LeftDrawerViewController = leftSideNavController;

			DrawerController.RestorationIdentifier = "MMDrawer";
			DrawerController.MaximumRightDrawerWidth = 200.0F;
			DrawerController.OpenDrawerGestureModeMask = MMOpenDrawerGestureMode.BezelPanningCenterView;
			DrawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.BezelPanningCenterView;

			//DrawerController.DrawerVisualStateBlock = new Action (DrawerAction (DrawerController, new MMDrawerSide(), 100F));

			this.Window = new UIWindow (UIScreen.MainScreen.Bounds);
			UIColor tintColor = new UIColor (29.0F / 255.0F, 173.0F / 255.0F, 234.0F / 255.0F, 1.0F);
			this.Window.TintColor = tintColor;

			this.Window.RootViewController = this.DrawerController;

			return true;
		}

		public Action DrawerAction(MMDrawerController.MMDrawerController drawerControler, MMDrawerSide drawSide, Single porcentVisible){
			//drawerControler.DrawerVisualStateBlock=mmex
			return null;
		}

		[Export ("application:didFinishLaunchingWithOptions:")]
		public bool FinishedLaunching (MonoTouch.UIKit.UIApplication application, MonoTouch.Foundation.NSDictionary launchOptions)
		{
			this.Window.BackgroundColor = UIColor.White;
			this.Window.MakeKeyAndVisible ();
			return true;
		}	

		[Export ("application:shouldSaveApplicationState:")]
		public bool ShouldSaveApplicationState (MonoTouch.UIKit.UIApplication application, MonoTouch.Foundation.NSCoder coder)
		{
			return true;
		}

		[Export ("application:shouldRestoreApplicationState:")]
		public bool ShouldRestoreApplicationState (MonoTouch.UIKit.UIApplication application, MonoTouch.Foundation.NSCoder coder)
		{
			return true;
		}

		[Export ("application:viewControllerWithRestorationIdentifierPath:coder:")]
		public MonoTouch.UIKit.UIViewController GetViewController (MonoTouch.UIKit.UIApplication application, string[] restorationIdentifierComponents, MonoTouch.Foundation.NSCoder coder)
		{
			NSString key = (NSString)restorationIdentifierComponents.Last<Object> ();
			if (key.Equals ("MMDrawer")) {
				return this.Window.RootViewController;
			} else if (key.Equals ("MMExampleCenterNavigationControllerRestorationKey")) {
				return ((MMDrawerController.MMDrawerController)this.Window.RootViewController).CenterViewController;
			} else if (key.Equals ("MMExampleRightNavigationControllerRestorationKey")) {
				return ((MMDrawerController.MMDrawerController)this.Window.RootViewController).RightDrawerViewController;
			} else if (key.Equals ("MMExampleLeftNavigationControllerRestorationKey")) {
				return ((MMDrawerController.MMDrawerController)this.Window.RootViewController).LeftDrawerViewController;
			} else if (key.Equals ("MMExampleLeftSideDrawerController")) {
				UIViewController leftVC = ((MMDrawerController.MMDrawerController)this.Window.RootViewController).LeftDrawerViewController;
				if (leftVC.GetType () == typeof(UINavigationController)) {
					return ((UINavigationController)leftVC).TopViewController;
				} else {
					return leftVC;
				}
			} else if (key.Equals ("MMExampleRightSideDrawerController")) {
				UIViewController rightVC = ((MMDrawerController.MMDrawerController)this.Window.RootViewController).RightDrawerViewController;
				if (rightVC.GetType () == typeof(UINavigationController)) {
					return ((UINavigationController)rightVC).TopViewController;
				} else {
					return rightVC;
				}
			}
			return null;
		}

		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public  void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public  void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public  void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public  void WillTerminate (UIApplication application)
		{
		}
	}
}

