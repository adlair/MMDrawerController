using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace MMDrawerControllerKitchenSink
{
	public class MMCustomCheckmark : UIControl
	{
		public UIColor Color {
			get;
			set;
		}

		public MMCustomCheckmark (RectangleF frame)
		{
			this.Init ();
			this.Frame = frame;
		}

		public override void DrawRect (System.Drawing.RectangleF area, UIViewPrintFormatter formatter)
		{
			base.DrawRect (area, formatter);

			UIColor checkMarkColor = this.Color;

			RectangleF frame = this.Bounds;

			UIBezierPath checkMarkPath = new UIBezierPath ();
			checkMarkPath.MoveTo (new PointF (frame.GetMinX () + 0.07087F * frame.Width, frame.GetMinY () + 0.48855F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.12500F * frame.Width, frame.GetMinY() + 0.45284F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.21038F * frame.Width, frame.GetMinY() + 0.47898F * frame.Height),
				new PointF (frame.GetMinX() + 0.15489F * frame.Width, frame.GetMinY() + 0.43312F * frame.Height),
				new PointF (frame.GetMinX() + 0.19312F * frame.Width, frame.GetMinY() + 0.44482F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.51450F * frame.Width, frame.GetMinY() + 0.79528F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.49163F * frame.Width, frame.GetMinY() + 0.89286F * frame.Height),
				new PointF (frame.GetMinX() + 0.53176F * frame.Width, frame.GetMinY() + 0.82945F * frame.Height),
				new PointF (frame.GetMinX() + 0.52152F * frame.Width, frame.GetMinY() + 0.87313F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.38337F * frame.Width, frame.GetMinY() + 0.96429F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.07087F * frame.Width, frame.GetMinY() + 0.48855F * frame.Height),
				new PointF (frame.GetMinX() + 0.03074F * frame.Width, frame.GetMinY() + 0.55196F * frame.Height),
				new PointF (frame.GetMinX() + 0.04098F * frame.Width, frame.GetMinY() + 0.50828F * frame.Height));
			checkMarkPath.ClosePath ();
			checkMarkPath.MoveTo (new PointF (frame.GetMinX () + 0.92048F * frame.Width, frame.GetMinY () + 0.00641F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.93750F * frame.Width, frame.GetMinY() + 0.02427F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.96038F * frame.Width, frame.GetMinY() + 0.12184F * frame.Height),
				new PointF (frame.GetMinX() + 0.96739F * frame.Width, frame.GetMinY() + 0.04399F * frame.Height),
				new PointF (frame.GetMinX() + 0.97764F * frame.Width, frame.GetMinY() + 0.08768F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.51450F * frame.Width, frame.GetMinY() + 0.93814F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.42913F * frame.Width, frame.GetMinY() + 0.96429F * frame.Height),
				new PointF (frame.GetMinX() + 0.49724F * frame.Width, frame.GetMinY() + 0.97230F * frame.Height),
				new PointF (frame.GetMinX() + 0.45902F * frame.Width, frame.GetMinY() + 0.98401F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.32087F * frame.Width, frame.GetMinY() + 0.89286F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.29800F * frame.Width, frame.GetMinY() + 0.79528F * frame.Height),
				new PointF (frame.GetMinX() + 0.29098F * frame.Width, frame.GetMinY() + 0.87313F * frame.Height),
				new PointF (frame.GetMinX() + 0.28074F * frame.Width, frame.GetMinY() + 0.82945F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.83511F * frame.Width, frame.GetMinY() + 0.03255F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.92048F * frame.Width, frame.GetMinY() + 0.00641F * frame.Height),
				new PointF (frame.GetMinX() + 0.85237F * frame.Width, frame.GetMinY() + 0.00161F * frame.Height),
				new PointF (frame.GetMinX() + 0.89059F * frame.Width, frame.GetMinY() + -0.01331F * frame.Height));
			checkMarkPath.ClosePath ();
			checkMarkPath.MoveTo (new PointF (frame.GetMinX () + 0.37500F * frame.Width, frame.GetMinY () + 0.78572F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.43750F * frame.Width, frame.GetMinY() + 0.78572F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.50000F * frame.Width, frame.GetMinY() + 0.85714F * frame.Height),
				new PointF (frame.GetMinX() + 0.47202F * frame.Width, frame.GetMinY() + 0.78572F * frame.Height),
				new PointF (frame.GetMinX() + 0.50000F * frame.Width, frame.GetMinY() + 0.81769F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.50000F * frame.Width, frame.GetMinY() + 0.92857F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.43750F * frame.Width, frame.GetMinY() + 1.00000F * frame.Height),
				new PointF (frame.GetMinX() + 0.50000F * frame.Width, frame.GetMinY() + 0.96802F * frame.Height),
				new PointF (frame.GetMinX() + 0.47202F * frame.Width, frame.GetMinY() + 1.00000F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.37500F * frame.Width, frame.GetMinY() + 1.00000F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.31250F * frame.Width, frame.GetMinY() + 0.92857F * frame.Height),
				new PointF (frame.GetMinX() + 0.34048F * frame.Width, frame.GetMinY() + 1.00000F * frame.Height),
				new PointF (frame.GetMinX() + 0.31250F * frame.Width, frame.GetMinY() + 0.96802F * frame.Height));
			checkMarkPath.AddLineTo (new PointF (frame.GetMinX() + 0.31250F * frame.Width, frame.GetMinY() + 0.85714F * frame.Height));
			checkMarkPath.AddCurveToPoint (
				new PointF (frame.GetMinX() + 0.37500F * frame.Width, frame.GetMinY() + 0.78572F * frame.Height),
				new PointF (frame.GetMinX() + 0.31250F * frame.Width, frame.GetMinY() + 0.81769F * frame.Height),
				new PointF (frame.GetMinX() + 0.34048F * frame.Width, frame.GetMinY() + 0.78572F * frame.Height));
			checkMarkPath.ClosePath ();
			checkMarkColor.SetFill ();
			checkMarkPath.Fill ();
		}

		public override bool Selected {
			get {
				return base.Selected;
			}
			set {
				base.Selected = value;
			}
		}
	}
}

