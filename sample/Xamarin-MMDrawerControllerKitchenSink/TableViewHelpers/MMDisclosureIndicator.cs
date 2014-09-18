using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace MMDrawerControllerKitchenSink
{
	public class MMDisclosureIndicator : UIView
	{
		public UIColor Color{
			get;
			set;
		}

		public MMDisclosureIndicator (RectangleF frame)
		{
			this.Init ();
			this.Frame = frame;
		}

		public override void DrawRect (System.Drawing.RectangleF area, UIViewPrintFormatter formatter)
		{
			base.DrawRect (area, formatter);
			CGContext context = UIGraphics.GetCurrentContext ();

			UIColor shadow;
			shadow = UIColor.Clear;

			UIColor chevronColor = this.Color;
			SizeF shadowOffset = new SizeF (0.1F, 1.1F);
			Single shadowBlurRadius = 0F;

			RectangleF frame = new RectangleF (this.Bounds.X, this.Bounds.Y, this.Bounds.Width, this.Bounds.Height);

			UIBezierPath chevronPath = new UIBezierPath ();
			chevronPath.MoveTo (new PointF (frame.GetMinX () + 0.22000F * frame.Width, frame.GetMinY () + 0.01667F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.98000F * frame.Width, frame.GetMinY() + 0.48333F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.22000F * frame.Width, frame.GetMinY() + 0.98333F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.02000F * frame.Width, frame.GetMinY() + 0.81667F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.54000F * frame.Width, frame.GetMinY() + 0.48333F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.02000F * frame.Width, frame.GetMinY() + 0.15000F * frame.Height));
			chevronPath.AddLineTo (new PointF (frame.GetMinX() + 0.22000F * frame.Width, frame.GetMinY() + 0.01667F * frame.Height));
			chevronPath.ClosePath ();
			context.SaveState ();
			context.SetShadowWithColor (shadowOffset, shadowBlurRadius, shadow.CGColor);
			chevronColor.SetFill ();
			chevronPath.Fill ();
			context.RestoreState ();
		}
	}
}

