using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace MMDrawerControllerKitchenSink
{
	public class MMTableViewCell : UITableViewCell
	{
		public MMTableViewCell ()
		{
			this.Init ();
			this.AccessoryCheckmarkColor = UIColor.White;
			this.DisclosureIndicatorColor = UIColor.White;
			this.UpdateContentForNewContentSize ();
		}

		public UIColor AccessoryCheckmarkColor {
			get;
			set;
		}

		public UIColor DisclosureIndicatorColor {
			get;
			set;
		}

		public override bool Selected {
			get {
				return base.Selected;
			}
			set {
				base.Selected = value;
			}
		}

		public bool Animated {
			get;
			set;
		}

		public override UITableViewCellAccessory Accessory {
			get {
				return base.Accessory;
			}
			set {
				base.Accessory = value;
				if (base.Accessory == UITableViewCellAccessory.Checkmark) {
					MMCustomCheckmark customCheckmark = new MMCustomCheckmark (this.Frame);
					customCheckmark.Frame = new RectangleF (0F, 0F, 15F, 15F);
					customCheckmark.Color = this.AccessoryCheckmarkColor;
					this.AccessoryView = customCheckmark;
				} else if (Accessory == UITableViewCellAccessory.DisclosureIndicator) {
					MMDisclosureIndicator di = new MMDisclosureIndicator (this.Frame);
					di.Frame = new RectangleF (0F, 0F, 10F, 14F);
					di.Color = this.DisclosureIndicatorColor;
					this.AccessoryView = di;
				} else {
					this.AccessoryView = null;
				}
			}
		}

		public override void PrepareForReuse ()
		{
			base.PrepareForReuse ();
			this.UpdateContentForNewContentSize ();
		}

		public void UpdateContentForNewContentSize(){
		}
	}
}

