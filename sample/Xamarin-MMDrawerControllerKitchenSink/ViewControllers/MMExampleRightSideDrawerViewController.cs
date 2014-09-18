using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMExampleRightSideDrawerViewController : MMExampleSideDrawerViewController
	{
		public UITableView TableView {
			get;
			set;
		}

		public NSArray DrawerWidths {
			get;
			set;
		}

		public MMExampleRightSideDrawerViewController ()
		{
			base.Init ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Console.WriteLine ("Right will appear");
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			Console.WriteLine ("Right did appear");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Console.WriteLine ("Right will disappear");
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			Console.WriteLine ("Right did disappear");
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = "Right Drawer";
		}

		[Export ("tableView:titleForHeaderInSection:")]
		public string TitleForHeader (MonoTouch.UIKit.UITableView tableView, int section)
		{
			if (section == 1)
				return "Right Drawer Width";
			else
				return base.TitleForHeader (tableView, section);
		}

		[Export("tableView:cellForRowAtIndexPath:")]
		public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = base.GetCell (tableView, indexPath);
			if (indexPath.Section == 1) {
				Single width = (Single)this.DrawerWidths.ValueAt ((uint)indexPath.Row);
				Single drawerWidths = MMDrawerController_UIViewController.Mm_drawerController.MaximumRightDrawerWidth;
				if (drawerWidths == width) {
					cell.Accessory = UITableViewCellAccessory.Checkmark;
				} else {
					cell.Accessory = UITableViewCellAccessory.None;
				}
			}
			return cell;
		}

		[Export ("tableView:didSelectRowAtIndexPath:")]
		public void RowSelected (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			if (indexPath.Section == 1) {
				//MMDrawerController_UIViewController.Mm_drawerController.SetMaximumRightDrawerWidth ((float)this.DrawerWidths.ValueAt ((uint)indexPath.Row), true, new Action ());
			} else {
				base.RowSelected (tableView, indexPath);
			}
		}
	}
}

