using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMExampleLeftSideDrawerViewController : MMExampleSideDrawerViewController
	{
		public NSArray DrawerWidths {
			get;
			set;
		}

		public MMExampleLeftSideDrawerViewController()
		{
			this.Init ();
			this.RestorationIdentifier = "MMExampleLeftSideDrawerController";

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Console.WriteLine("Left will appear");
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			Console.WriteLine ("Left did appear");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Console.WriteLine("Left will disappear");
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			Console.WriteLine ("Left did disappear");
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = "Left Drawer";
		}


		public NSString TitleForHeader(UITableView tableView, int section){
			if (section == 1)
				return (NSString)@"Left Drawer Width";
			else
				return (NSString)base.TitleForHeader (tableView, section);
		}


		public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath){
			UITableViewCell cell = tableView.CellAt (indexPath);
			if (indexPath.Section == 1) {
				Single width = this.DrawerWidths.ValueAt ((uint)indexPath.Row).ToInt32 ();
				Single drawerWidth = MMDrawerController_UIViewController.Mm_drawerController.MaximumLeftDrawerWidth;
				if (drawerWidth == width) {
					cell.Accessory = UITableViewCellAccessory.Checkmark;
				} else {
					cell.Accessory = UITableViewCellAccessory.None;
				}
				cell.TextLabel.Text = String.Format ("Widht {0}", this.DrawerWidths.ValueAt ((uint)indexPath.Row).ToInt32 ());
			}
			return cell;
		}


		public void RowSelected (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath){
			if (indexPath.Section == 1) {
				MMDrawerController_UIViewController.Mm_drawerController.SetMaximumLeftDrawerWidth ((float)this.DrawerWidths.ValueAt ((uint)indexPath.Row).ToInt32 (), true, null);
			} else {
				base.RowSelected (tableView, indexPath);
			}
		}
	}
}
