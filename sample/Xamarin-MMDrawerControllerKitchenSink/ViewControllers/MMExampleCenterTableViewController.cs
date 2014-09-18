using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	enum MMCenterViewControllerSection{
		LeftViewState = 0,
		LeftDrawerAnimation = 1,
		RightViewState = 2,
		RightDrawerAnimation = 3
	}

	public class MMExampleCenterTableViewController : MMExampleViewController, IUITableViewDataSource, IUITableViewDelegate
	{
		UITableView TableView {
			get;
			set;
		}

		public MMExampleCenterTableViewController(){
			this.Init ();
			this.RestorationIdentifier = "MMExampleCenterControllerRestorationKey";
		}

		public override void ViewDidLoad(){
			this.TableView = new UITableView (this.View.Bounds, UITableViewStyle.Grouped);
			base.ViewDidLoad ();
			this.View.AddSubview (this.TableView);

			UITapGestureRecognizer doubleTap = new UITapGestureRecognizer ();
			doubleTap.NumberOfTapsRequired = 2;
			this.View.AddGestureRecognizer (doubleTap);

			UITapGestureRecognizer twoFingerDoubleTap = new UITapGestureRecognizer ();
			twoFingerDoubleTap.NumberOfTapsRequired = 2;
			twoFingerDoubleTap.NumberOfTouchesRequired = 2;
			this.View.AddGestureRecognizer (twoFingerDoubleTap);

			this.SetupLeftButton ();
			this.SetupRightButton ();

			UIColor barColor = new UIColor (247.0F / 255.0F, 249.0F / 255.0F, 250.0F / 255.0F, 1.0F);
			this.NavigationController.NavigationBar.BarTintColor = barColor;

			MMLogoView logo = new MMLogoView (new RectangleF (0F, 0F, 29F, 31F));
			this.NavigationItem.TitleView = logo;
			this.NavigationController.View.Layer.CornerRadius = 10.0F;

			UIView backView = new UIView ();
			backView.BackgroundColor = new UIColor (208.0F / 255.0F, 208.0F / 255.0F, 208.0F / 255.0F, 1.0F);
			this.TableView.BackgroundView = backView;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Console.WriteLine ("Center will appear");
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			Console.WriteLine ("Center did appear");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Console.WriteLine ("Center will disappear");
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			Console.WriteLine ("Center did disappear");
		}
			
		public void SetupLeftButton(){
			MMDrawerBarButtonItem leftDrawerButton = new MMDrawerBarButtonItem (this, LeftDrawerButtonPress());
			this.NavigationItem.SetLeftBarButtonItem (leftDrawerButton, true);
		}

		public void SetupRightButton(){
			//MMDrawerBarButtonItem rightDrawerButton = new MMDrawerBarButtonItem (this, RightDrawerButtonPress());
			//this.NavigationItem.SetLeftBarButtonItem (rightDrawerButton, true);
		}

		public void ContentSizeDidChange(NSString size){
			this.TableView.ReloadData ();
		}

		[Export ("numberOfSectionsInTableView:")]
		public int NumberOfSections (MonoTouch.UIKit.UITableView tableView)
		{
			return 4;
		}

		[Export("tableView:cellForRowAtIndexPath:")]
		public UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			NSString cellIdentifier = (NSString)"Cell";
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
				cell.SelectionStyle = UITableViewCellSelectionStyle.Gray;
			}
			UIColor selectedColor = new UIColor (1.0F / 255.0F, 15.0F / 255.0F, 25.0F / 255.0F, 1.0F);
			UIColor unselectedColor = new UIColor (79.0F / 255.0F, 93.0F / 255.0F, 102.0F / 255.0F, 1.0F);
			switch (indexPath.Section) {
			case 1:
			case 3:
				cell.Accessory = UITableViewCellAccessory.Checkmark;
				cell.TextLabel.TextColor = selectedColor;
				cell.TextLabel.Text = "Slide";
				break;
			case 0:
				cell.TextLabel.Text = "Enabled";
				cell.Accessory = UITableViewCellAccessory.Checkmark;
				break;
			case 2:
				cell.TextLabel.Text = "Enabled";
				cell.Accessory = UITableViewCellAccessory.Checkmark;
				break;
			default:
				break;
			}
			return cell;
		}

		[Export ("tableView:didSelectRowAtIndexPath:")]
		public void DidSelectRow (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			switch (indexPath.Section) {
			case 1:
			case 3:
				MMExampleDrawerVisualStateManager sharedManager = new MMExampleDrawerVisualStateManager ();
				if (indexPath.Section == 1) {
					//sharedManager.LeftDrawerAnimationType = indexPath.Row;
				} else {
					//sharedManager.RightDrawerAnimationType = indexPath.Row;
				}
				//tableView.ReloadSections (indexPath.Section, UITableViewRowAnimation.None);
				tableView.SelectRow (indexPath, false, UITableViewScrollPosition.None);
				tableView.DeselectRow (indexPath, true);
				break;
			case 0:
			case 2:
				UIViewController sideDrawerViewController = MMDrawerController_UIViewController.Mm_drawerController.RightDrawerViewController;
				;
				MMDrawerSide drawerSide = MMDrawerSide.None;
				if (indexPath.Section == 0) {
					drawerSide = MMDrawerSide.Left;
				} else if (indexPath.Section == 2) {
					sideDrawerViewController = MMDrawerController_UIViewController.Mm_drawerController.RightDrawerViewController;
					drawerSide = MMDrawerSide.Right;
				}

				if (sideDrawerViewController != null) {
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerAnimated (true, completion());
				} else if (drawerSide == MMDrawerSide.Left) {
					UIViewController vc = new MMExampleLeftSideDrawerViewController ();
					UINavigationController navC = new MMNavigationController (vc);
					MMDrawerController_UIViewController.Mm_drawerController.RightDrawerViewController = navC;
					this.SetupRightButton ();
				}
				//tableView.ReloadRow (indexPath, UITableViewRowAnimation.None);
				tableView.SelectRow (indexPath, false, UITableViewScrollPosition.None);			
				break;
			default:
				break;
			}
		}

		Action completion(){
			return null;
		}

		public MMDrawerController.MMDrawerController MMDrawerControllerAction(){
			UIViewController parentViewController = this.ParentViewController;
			while (parentViewController != null) {
				if (parentViewController.GetType () == typeof(MMDrawerController.MMDrawerController)) {
					return (MMDrawerController.MMDrawerController)parentViewController;
				} else {
					parentViewController = parentViewController.ParentViewController;
				}
			}
			return null;
		}

		public RectangleF MMVisibleDrawerFrame(){
			if (this.Equals (MMDrawerControllerAction ().LeftDrawerViewController) || this.NavigationController.Equals (this.MMDrawerControllerAction ().LeftDrawerViewController)) {
				RectangleF rect = this.MMDrawerControllerAction ().View.Bounds;
				rect.Width = this.MMDrawerControllerAction ().MaximumLeftDrawerWidth;
				return rect;
			} else if (this.Equals (this.MMDrawerControllerAction ().RightDrawerViewController) || this.NavigationController.Equals (this.MMDrawerControllerAction ().RightDrawerViewController)) {
				RectangleF rect = this.MMDrawerControllerAction ().View.Bounds;
				rect.Width = this.MMDrawerControllerAction ().MaximumRightDrawerWidth;
				rect.X = this.MMDrawerControllerAction ().View.Bounds.Width - rect.Size.Width;
				return rect;
			} else {
				return new RectangleF ();
			}
		}

		public MonoTouch.ObjCRuntime.Selector LeftDrawerButtonPress(Sender sender){
			//MMDrawerController_UIViewController.Mm_drawerController.ToggleDrawerSide (MMDrawerSide.Left, true, null);
			return null;
		}

		public MonoTouch.ObjCRuntime.Selector RightDrawerButtonPress(){
			//MMDrawerController_UIViewController.Mm_drawerController.ToggleDrawerSide (MMDrawerSide.Right, true, null);
			return null;
		}

		public void DoubleTap(UITapGestureRecognizer gesture){
			MMDrawerController_UIViewController.Mm_drawerController.BouncePreviewForDrawerSide (MMDrawerSide.Left, null);
		}

		public void TwoFingerDoubleTap(UITapGestureRecognizer gesture){
			MMDrawerController_UIViewController.Mm_drawerController.BouncePreviewForDrawerSide (MMDrawerSide.Right, null);
		}

		public int RowsInSection (UITableView tableView, int section)
		{
			switch (section) {
			case 1:
			case 3:
				return 5;
				break;
			case 0:
			case 2:
				return 1;
				break;
			default:
				return 0;
			}
		}
	}
}

