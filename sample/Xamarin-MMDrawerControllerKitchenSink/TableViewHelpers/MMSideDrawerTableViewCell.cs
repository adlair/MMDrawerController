using System;
using System.Drawing;
using MonoTouch.UIKit;
using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMSideDrawerTableViewCell : MMTableViewCell
	{
		public MMSideDrawerTableViewCell ()
		{
			this.AccessoryCheckmarkColor = UIColor.White;

			UIView backgroundView = new UIView ();
			backgroundView.Frame = new RectangleF (this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this.Bounds.Height);
			backgroundView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			UIColor backgroundColor = new UIColor (122.0F / 255.0F, 126.0F / 255.0F, 128.0F / 255.0F, 1.0F);
			backgroundView.BackgroundColor = backgroundColor;

			this.BackgroundView = backgroundView;
			this.TextLabel.BackgroundColor = UIColor.Clear;
			this.TextLabel.TextColor = new UIColor (230.0F / 255.0F, 236.0F / 255.0F, 242.0F / 255.0F, 1.0F);
			this.TextLabel.ShadowColor = UIColor.Black;
			this.TextLabel.ShadowColor.ColorWithAlpha (0.5F);
			this.TextLabel.ShadowOffset = new SizeF (0F, 1F);
		}

		public void UpdateContentForNewContentSize(){
			this.TextLabel.Font = UIFont.BoldSystemFontOfSize (16.0F);
		}
	}
}

