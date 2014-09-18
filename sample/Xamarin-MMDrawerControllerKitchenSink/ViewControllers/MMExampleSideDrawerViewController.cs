using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;
using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMExampleSideDrawerViewController : MMExampleViewController, IUITableViewDataSource, IUITableViewDelegate
	{
		public enum MMDrawerSection{
			ViewSelection = 0,
			DrawerWidth = 1,
			ShadowToggle = 2,
			OpenDrawerGestures = 3,
			CloseDrawerGestures = 4,
			CenterHiddenInteraction = 5,
			StretchDrawer = 6
		}

		UITableView TableView {
			get;
			set;
		}

		NSArray DrawerWidths {
			get;
			set;
		}

		public MMExampleSideDrawerViewController ()
		{
			this.Init ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TableView = new UITableView (this.View.Frame, UITableViewStyle.Grouped);
			TableView.Delegate = this.TableView.Delegate;
			TableView.DataSource = this.TableView.DataSource;
			this.View.AddSubview (this.TableView);
			TableView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

			UIColor tableViewBackgroundColor = new UIColor (110.0F / 255.0F, 113.0F / 255.0F, 115.0F / 255.0F, 1.0F);
			UIColor barColor = new UIColor (161.0F / 255.0F, 164.0F / 255.0F, 166.0F / 255.0F, 1.0F);

			this.TableView.BackgroundColor = tableViewBackgroundColor;
			this.TableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			this.View.BackgroundColor = new UIColor (161.0F / 255.0F, 164.0F / 255.0F, 166.0F / 255.0F, 1.0F);
			//if(this.NavigationController.NavigationBar RespondsToSelector(UIAppearance.SelectorAppearance)){
			this.NavigationController.NavigationBar.BarTintColor = barColor;

			UIColor titleColor = new UIColor (55.0F / 255.0F, 70.0F / 255.0F, 77.0F / 255.0F, 1.0F);

			this.NavigationController.NavigationBar.SetTitleTextAttributes (new UITextAttributes (){ TextColor = titleColor });

			this.DrawerWidths = NSArray.FromStrings (new string[] { "160", "200", "240", "280", "320" });
			SizeF logoSize = new SizeF (58F, 62F);
			MMLogoView logo = new MMLogoView (this.View.Frame);
			logo.Frame = new RectangleF (this.TableView.Bounds.GetMidX () - logoSize.Width / 2.0F, -logoSize.Height - logoSize.Height / 4.0F, logoSize.Width, logoSize.Height);
			logo.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleRightMargin;
			this.TableView.AddSubview (logo);
			this.View.BackgroundColor = UIColor.Clear;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.TableView.ReloadSections (NSIndexSet.FromNSRange (new NSRange (0, this.TableView.NumberOfSections () - 1)), UITableViewRowAnimation.None);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Dispose of any resources that can be recreated.
		}

		public void ContentSizeDidChange(NSString size){
			this.TableView.ReloadData ();
		}

		[Export ("numberOfSectionsInTableView:")]
		public int NumberOfSections (MonoTouch.UIKit.UITableView tableView)
		{
			// Return the number of sections.
			return 7;
		}

		public int RowsInSection (UITableView tableView, int section){
			return tableView.NumberOfRowsInSection (section);
		}

		[Export("TableView:cellForRowAtIndexPath:")]
		public UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath){
			NSString cellIdentifier = (NSString)@"Cell";
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null) {
				cell = new MMSideDrawerTableViewCell ();
				cell.SelectionStyle = UITableViewCellSelectionStyle.Blue;
			}
			switch (indexPath.Section) {
			case 2:
				if (indexPath.Row == 0) {
					cell.TextLabel.Text = "Quick View Change";
				} else {
					cell.TextLabel.Text = "Full View Change";
				}
				cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
				break;
			case 1:
				cell.TextLabel.Text = "Show Shadow";
				if (MMDrawerController_UIViewController.Mm_drawerController.ShowsShadow) {
					cell.Accessory = UITableViewCellAccessory.Checkmark;
				} else {
					cell.Accessory = UITableViewCellAccessory.None;
				}
				break;
			case 3:
				switch (indexPath.Row) {
				case 0:
					cell.TextLabel.Text = "Pan Nav Bar";
					if (MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask>0 && MMOpenDrawerGestureMode.PanningNavigationBar > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 1:
					cell.TextLabel.Text = "Pan Center View";
					if (MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask>0 && MMOpenDrawerGestureMode.PanningCenterView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 2:
					cell.TextLabel.Text = "Bezel Pan Center View";
					if (MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask>0 && MMOpenDrawerGestureMode.BezelPanningCenterView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				default:
					break;
				}
				break;
			case 6:
				switch (indexPath.Row) {
				case 0:
					cell.TextLabel.Text = "Pan Nav Bar";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.PanningNavigationBar > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 1:
					cell.TextLabel.Text = "Pan Center View";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.PanningCenterView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 2:
					cell.TextLabel.Text = "Bezel Pan Center View";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.BezelPanningCenterView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 3:
					cell.TextLabel.Text = "Tap Nav Bar";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.TapNavigationBar > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 4:
					cell.TextLabel.Text = "Tap Center View";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.TapCenterView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				case 5:
					cell.TextLabel.Text = "Pan Drawer View";
					if (MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask>0 && MMCloseDrawerGestureMode.PanningDrawerView > 0) {
						cell.Accessory = UITableViewCellAccessory.Checkmark;
					} else {
						cell.Accessory = UITableViewCellAccessory.None;
					}
					break;
				default:
					break;
				}
				break;
			default:
				break;
			}
			return cell;
		}

		[Export ("tableView:titleForHeaderInSection:")]
		public string TitleForHeader (MonoTouch.UIKit.UITableView tableView, int section)
		{
			switch (section) {
			case 0:
				return @"New Center View";
			case 1:
				return @"Drawer Width";
			case 2:
				return @"Shadow";
			case 3:
				return @"Drawer Open Gestures";
			case 4:
				return @"Drawer Close Gestures";
			case 5:
				return @"Open Center Interaction Mode";
			case 6:
				return @"Strech Drawer";
			default:
				return null;
			}
		}

		[Export ("tableView:viewForHeaderInSection:")]
		public MonoTouch.UIKit.UIView GetViewForHeader (MonoTouch.UIKit.UITableView tableView, int section)
		{
			//MMSideDrawerTableViewCell
			return null;
		}

		[Export ("tableView:heightForHeaderInSection:")]
		public float GetHeightForHeader (MonoTouch.UIKit.UITableView tableView, int section)
		{
			return 56.0F;
		}

		[Export ("tableView:heightForRowAtIndexPath:")]
		public float GetHeightForRow (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return 40.0F;
		}

		[Export ("tableView:heightForFooterInSection:")]
		public float GetHeightForFooter (MonoTouch.UIKit.UITableView tableView, int section)
		{
			return 0.0F;
		}

		[Export ("tableView:didSelectRowAtIndexPath:")]
		public void RowSelected (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			switch (indexPath.Section) {
			case 0: //MMDrawerSectionViewSelection
				MMExampleCenterTableViewController center = new MMExampleCenterTableViewController ();
				UINavigationController nav = new UINavigationController (center);
				if (indexPath.Row % 2 == 0) {
					MMDrawerController_UIViewController.Mm_drawerController.CenterViewController = nav;
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerAnimated (true, null);
				} else {
					MMDrawerController_UIViewController.Mm_drawerController.CenterViewController = nav;
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerAnimated (true, null);
				}
				break;
			case 1: //MMDrawerSectionDrawerWidth
				break;
			case 2: //MMDrawerSectionShadowToggle
				MMDrawerController_UIViewController.Mm_drawerController.ShowsShadow = MMDrawerController_UIViewController.Mm_drawerController.ShowsShadow;
				tableView.ReloadSections (NSIndexSet.FromIndex (indexPath.Section), UITableViewRowAnimation.None);
				break;
			case 3: //MMDrawerSectionOpenDrawerGestures
				switch (indexPath.Row) {
				case 0:
					MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask = MMOpenDrawerGestureMode.PanningNavigationBar;
					break;
				case 1:
					MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask = MMOpenDrawerGestureMode.PanningCenterView;
					break;
				case 2:
					MMDrawerController_UIViewController.Mm_drawerController.OpenDrawerGestureModeMask = MMOpenDrawerGestureMode.BezelPanningCenterView;
					break;
				default:
					break;
				}
				tableView.ReloadRows (new NSIndexPath[]{ indexPath }, UITableViewRowAnimation.None);
				break;
			case 4: //MMDrawerSectionCloseDrawerGestures
				switch (indexPath.Row) {
				case 0:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.PanningNavigationBar;
					break;
				case 1:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.PanningCenterView;
					break;
				case 2:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.BezelPanningCenterView;
					break;
				case 3:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.TapNavigationBar;
					break;
				case 4:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.TapCenterView;
					break;
				case 5:
					MMDrawerController_UIViewController.Mm_drawerController.CloseDrawerGestureModeMask = MMCloseDrawerGestureMode.PanningDrawerView;
					break;
				default:
					break;
				}
				tableView.ReloadRows (new NSIndexPath[]{ indexPath }, UITableViewRowAnimation.None);
				break;
			case 5: //MMDrawerSectionCenterHiddenInteraction
				tableView.ReloadRows (new NSIndexPath[]{ indexPath }, UITableViewRowAnimation.None);
				break;
			case 6: //MMDrawerSectionStretchDrawer
				MMDrawerController_UIViewController.Mm_drawerController.ShouldStretchDrawer = !MMDrawerController_UIViewController.Mm_drawerController.ShouldStretchDrawer;
				tableView.ReloadSections (NSIndexSet.FromIndex (indexPath.Section), UITableViewRowAnimation.None);
				break;
			default:
				break;
			}
			tableView.SelectRow (indexPath, false, UITableViewScrollPosition.None);
			tableView.DeselectRow (indexPath, true);
		}
	}
}

