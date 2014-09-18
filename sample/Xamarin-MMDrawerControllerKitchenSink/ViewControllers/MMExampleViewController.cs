using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MMDrawerControllerKitchenSink
{
	public class MMExampleViewController : UIViewController
	{
		public MMExampleViewController ()
		{
			base.Init ();
		}

		public override string NibName {
			get {
				return base.NibName;
			}
		}

		public override NSBundle NibBundle {
			get {
				return base.NibBundle;
			}
		}

		public override void ViewDidLoad(){
			base.ViewDidLoad ();
			NSNotificationCenter defaultCenter = new NSNotificationCenter ();
			defaultCenter.AddObserver (null, ContentSizeDidChangeNotification, this);
			//defaultCenter.PerformSelector(MonoTouch.ObjCRuntime.Selector, ContentSizeDidChangeNotification);
		}

		public void Dealloc(){
			NSNotificationCenter defaultCenter = new NSNotificationCenter ();
			defaultCenter.RemoveObserver (this, null);
		}

		public void ContentSizeDidChangeNotification(NSNotification notification){
			this.ContentSizeDidChange ((NSString)notification.UserInfo.ToString());
		}

		public void ContentSizeDidChange(NSString size){
			//Implement in subclass
		}
	}
}

