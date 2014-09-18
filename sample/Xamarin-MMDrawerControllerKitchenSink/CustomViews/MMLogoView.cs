using System;
using System.Drawing;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;

namespace MMDrawerControllerKitchenSink
{
	public class MMLogoView : UIView
	{
		public UIWindow Window {
			get;
			set;
		}

		public MMLogoView (RectangleF frame)
		{
			this.Init ();
			this.Frame = frame;
			this.BackgroundColor = UIColor.Clear;
		}

		public override void DrawRect (RectangleF area, UIViewPrintFormatter formatter)
		{
			base.DrawRect (area, formatter);

			//General Declarations
			CGContext context = UIGraphics.GetCurrentContext ();

			// Color Declarations
			UIColor mmFill = new UIColor (0F, 0F, 0F, 0.196F);
			UIColor shape1DropShadowColor = new UIColor (1F, 1F, 1F, 0.4F);
			UIColor shape1InnerShadowColor = new UIColor (0F, 0F, 0F, 0.392F);

			// Shadow Declarations
			UIColor mmDropShadow = shape1DropShadowColor;
			SizeF mmDropShadowOffset = new SizeF (0.1F, 1.1F);
			Single mmDropShadowBlurRadius = 0;
			UIColor mmInnerShadow = shape1InnerShadowColor;
			SizeF mmInnerShadowOffset = new SizeF (0.1F, 1.1F);
			Single mmInnerShadowBlurRadius = 0;

			// Frames
			RectangleF frame = this.Bounds;

			// mmGroup
			{
				// mmShape Drawing
				UIBezierPath mmShapePath = new UIBezierPath ();
				mmShapePath.MoveTo (new PointF (frame.GetMinX () + 0.51759F * frame.Width, frame.GetMinY () + 0.96761F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.37558F * frame.Width, frame.GetMinY() + 0.91398F * frame.Height),
					new PointF (frame.GetMinX() + 0.46395F * frame.Width, frame.GetMinY() + 0.96761F * frame.Height),
					new PointF (frame.GetMinX() + 0.41351F * frame.Width, frame.GetMinY() + 0.94854F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.31759F * frame.Width, frame.GetMinY() + 0.76824F * frame.Height),
					new PointF (frame.GetMinX() + 0.33346F * frame.Width, frame.GetMinY() + 0.87556F * frame.Height),
					new PointF (frame.GetMinX() + 0.31234F * frame.Width, frame.GetMinY() + 0.82249F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.31904F * frame.Width, frame.GetMinY() + 0.75325F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.30262F * frame.Width, frame.GetMinY() + 0.75459F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.28470F * frame.Width, frame.GetMinY() + 0.75535F * frame.Height),
					new PointF (frame.GetMinX() + 0.29666F * frame.Width, frame.GetMinY() + 0.75510F * frame.Height),
					new PointF (frame.GetMinX() + 0.29065F * frame.Width, frame.GetMinY() + 0.75535F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.14274F * frame.Width, frame.GetMinY() + 0.70173F * frame.Height),
					new PointF (frame.GetMinX() + 0.23106F * frame.Width, frame.GetMinY() + 0.75535F * frame.Height),
					new PointF (frame.GetMinX() + 0.18067F * frame.Width, frame.GetMinY() + 0.73625F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.14274F * frame.Width, frame.GetMinY() + 0.44291F * frame.Height),
					new PointF (frame.GetMinX() + 0.06451F * frame.Width, frame.GetMinY() + 0.63038F * frame.Height),
					new PointF (frame.GetMinX() + 0.06451F * frame.Width, frame.GetMinY() + 0.51425F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.45528F * frame.Width, frame.GetMinY() + 0.15799F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.48085F * frame.Width, frame.GetMinY() + 0.14832F * frame.Height),
					new PointF (frame.GetMinX() + 0.46207F * frame.Width, frame.GetMinY() + 0.15176F * frame.Height),
					new PointF (frame.GetMinX() + 0.47120F * frame.Width, frame.GetMinY() + 0.14832F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.50639F * frame.Width, frame.GetMinY() + 0.15799F * frame.Height),
					new PointF (frame.GetMinX() + 0.49051F * frame.Width, frame.GetMinY() + 0.14832F * frame.Height),
					new PointF (frame.GetMinX() + 0.49957F * frame.Width, frame.GetMinY() + 0.15176F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.50639F * frame.Width, frame.GetMinY() + 0.20462F * frame.Height),
					new PointF (frame.GetMinX() + 0.52050F * frame.Width, frame.GetMinY() + 0.17087F * frame.Height),
					new PointF (frame.GetMinX() + 0.52050F * frame.Width, frame.GetMinY() + 0.19177F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.19390F * frame.Width, frame.GetMinY() + 0.48951F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.19386F * frame.Width, frame.GetMinY() + 0.65510F * frame.Height),
					new PointF (frame.GetMinX() + 0.14397F * frame.Width, frame.GetMinY() + 0.53518F * frame.Height),
					new PointF (frame.GetMinX() + 0.14397F * frame.Width, frame.GetMinY() + 0.60942F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.28476F * frame.Width, frame.GetMinY() + 0.68936F * frame.Height),
					new PointF (frame.GetMinX() + 0.21821F * frame.Width, frame.GetMinY() + 0.67720F * frame.Height),
					new PointF (frame.GetMinX() + 0.25047F * frame.Width, frame.GetMinY() + 0.68936F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.37557F * frame.Width, frame.GetMinY() + 0.65514F * frame.Height),
					new PointF (frame.GetMinX() + 0.31904F * frame.Width, frame.GetMinY() + 0.68936F * frame.Height),
					new PointF (frame.GetMinX() + 0.35128F * frame.Width, frame.GetMinY() + 0.67720F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.68812F * frame.Width, frame.GetMinY() + 0.37025F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.71365F * frame.Width, frame.GetMinY() + 0.36056F * frame.Height),
					new PointF (frame.GetMinX() + 0.69491F * frame.Width, frame.GetMinY() + 0.36401F * frame.Height),
					new PointF (frame.GetMinX() + 0.70403F * frame.Width, frame.GetMinY() + 0.36056F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.73923F * frame.Width, frame.GetMinY() + 0.37025F * frame.Height),
					new PointF (frame.GetMinX() + 0.72332F * frame.Width, frame.GetMinY() + 0.36056F * frame.Height),
					new PointF (frame.GetMinX() + 0.73241F * frame.Width, frame.GetMinY() + 0.36401F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.73923F * frame.Width, frame.GetMinY() + 0.41681F * frame.Height),
					new PointF (frame.GetMinX() + 0.75333F * frame.Width, frame.GetMinY() + 0.38310F * frame.Height),
					new PointF (frame.GetMinX() + 0.75333F * frame.Width, frame.GetMinY() + 0.40399F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.42673F * frame.Width, frame.GetMinY() + 0.70173F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.42670F * frame.Width, frame.GetMinY() + 0.86737F * frame.Height),
					new PointF (frame.GetMinX() + 0.37681F * frame.Width, frame.GetMinY() + 0.74744F * frame.Height),
					new PointF (frame.GetMinX() + 0.37681F * frame.Width, frame.GetMinY() + 0.82172F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.51759F * frame.Width, frame.GetMinY() + 0.90159F * frame.Height),
					new PointF (frame.GetMinX() + 0.45104F * frame.Width, frame.GetMinY() + 0.88944F * frame.Height),
					new PointF (frame.GetMinX() + 0.48328F * frame.Width, frame.GetMinY() + 0.90159F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.60840F * frame.Width, frame.GetMinY() + 0.86743F * frame.Height),
					new PointF (frame.GetMinX() + 0.55183F * frame.Width, frame.GetMinY() + 0.90159F * frame.Height),
					new PointF (frame.GetMinX() + 0.58413F * frame.Width, frame.GetMinY() + 0.88944F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.92092F * frame.Width, frame.GetMinY() + 0.58246F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.94646F * frame.Width, frame.GetMinY() + 0.57284F * frame.Height),
					new PointF (frame.GetMinX() + 0.92773F * frame.Width, frame.GetMinY() + 0.57623F * frame.Height),
					new PointF (frame.GetMinX() + 0.93682F * frame.Width, frame.GetMinY() + 0.57284F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.97208F * frame.Width, frame.GetMinY() + 0.58246F * frame.Height),
					new PointF (frame.GetMinX() + 0.95617F * frame.Width, frame.GetMinY() + 0.57284F * frame.Height),
					new PointF (frame.GetMinX() + 0.96523F * frame.Width, frame.GetMinY() + 0.57623F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.97208F * frame.Width, frame.GetMinY() + 0.62912F * frame.Height),
					new PointF (frame.GetMinX() + 0.98615F * frame.Width, frame.GetMinY() + 0.59535F * frame.Height),
					new PointF (frame.GetMinX() + 0.98615F * frame.Width, frame.GetMinY() + 0.61626F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.65956F * frame.Width, frame.GetMinY() + 0.91398F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.51759F * frame.Width, frame.GetMinY() + 0.96761F * frame.Height),
					new PointF (frame.GetMinX() + 0.62160F * frame.Width, frame.GetMinY() + 0.94854F * frame.Height),
					new PointF (frame.GetMinX() + 0.57117F * frame.Width, frame.GetMinY() + 0.96761F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.51759F * frame.Width, frame.GetMinY() + 0.96761F * frame.Height));
				mmShapePath.ClosePath ();
				mmShapePath.MoveTo (new PointF (frame.GetMinX() + 0.51965F * frame.Width, frame.GetMinY() + 0.81940F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.49408F * frame.Width, frame.GetMinY() + 0.80982F * frame.Height),
					new PointF (frame.GetMinX() + 0.50999F * frame.Width, frame.GetMinY() + 0.81940F * frame.Height),
					new PointF (frame.GetMinX() + 0.50091F * frame.Width, frame.GetMinY() + 0.81600F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.49408F * frame.Width, frame.GetMinY() + 0.76313F * frame.Height),
					new PointF (frame.GetMinX() + 0.48000F * frame.Width, frame.GetMinY() + 0.79686F * frame.Height),
					new PointF (frame.GetMinX() + 0.48000F * frame.Width, frame.GetMinY() + 0.77600F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.80659F * frame.Width, frame.GetMinY() + 0.47824F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.80662F * frame.Width, frame.GetMinY() + 0.31264F * frame.Height),
					new PointF (frame.GetMinX() + 0.85650F * frame.Width, frame.GetMinY() + 0.43259F * frame.Height),
					new PointF (frame.GetMinX() + 0.85650F * frame.Width, frame.GetMinY() + 0.35831F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.71574F * frame.Width, frame.GetMinY() + 0.27840F * frame.Height),
					new PointF (frame.GetMinX() + 0.78226F * frame.Width, frame.GetMinY() + 0.29053F * frame.Height),
					new PointF (frame.GetMinX() + 0.75001F * frame.Width, frame.GetMinY() + 0.27840F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.62493F * frame.Width, frame.GetMinY() + 0.31260F * frame.Height),
					new PointF (frame.GetMinX() + 0.68146F * frame.Width, frame.GetMinY() + 0.27840F * frame.Height),
					new PointF (frame.GetMinX() + 0.64921F * frame.Width, frame.GetMinY() + 0.29053F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.31239F * frame.Width, frame.GetMinY() + 0.59752F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.28684F * frame.Width, frame.GetMinY() + 0.60718F * frame.Height),
					new PointF (frame.GetMinX() + 0.30556F * frame.Width, frame.GetMinY() + 0.60378F * frame.Height),
					new PointF (frame.GetMinX() + 0.29644F * frame.Width, frame.GetMinY() + 0.60718F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.26125F * frame.Width, frame.GetMinY() + 0.59752F * frame.Height),
					new PointF (frame.GetMinX() + 0.27718F * frame.Width, frame.GetMinY() + 0.60718F * frame.Height),
					new PointF (frame.GetMinX() + 0.26808F * frame.Width, frame.GetMinY() + 0.60378F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.26125F * frame.Width, frame.GetMinY() + 0.55093F * frame.Height),
					new PointF (frame.GetMinX() + 0.24715F * frame.Width, frame.GetMinY() + 0.58467F * frame.Height),
					new PointF (frame.GetMinX() + 0.24715F * frame.Width, frame.GetMinY() + 0.56377F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.57377F * frame.Width, frame.GetMinY() + 0.26601F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.57380F * frame.Width, frame.GetMinY() + 0.10041F * frame.Height),
					new PointF (frame.GetMinX() + 0.62368F * frame.Width, frame.GetMinY() + 0.22029F * frame.Height),
					new PointF (frame.GetMinX() + 0.62368F * frame.Width, frame.GetMinY() + 0.14606F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.48291F * frame.Width, frame.GetMinY() + 0.06617F * frame.Height),
					new PointF (frame.GetMinX() + 0.54946F * frame.Width, frame.GetMinY() + 0.07832F * frame.Height),
					new PointF (frame.GetMinX() + 0.51721F * frame.Width, frame.GetMinY() + 0.06617F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.39208F * frame.Width, frame.GetMinY() + 0.10040F * frame.Height),
					new PointF (frame.GetMinX() + 0.44863F * frame.Width, frame.GetMinY() + 0.06617F * frame.Height),
					new PointF (frame.GetMinX() + 0.41637F * frame.Width, frame.GetMinY() + 0.07832F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.07956F * frame.Width, frame.GetMinY() + 0.38530F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.05400F * frame.Width, frame.GetMinY() + 0.39496F * frame.Height),
					new PointF (frame.GetMinX() + 0.07274F * frame.Width, frame.GetMinY() + 0.39149F * frame.Height),
					new PointF (frame.GetMinX() + 0.06365F * frame.Width, frame.GetMinY() + 0.39496F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.02841F * frame.Width, frame.GetMinY() + 0.38530F * frame.Height),
					new PointF (frame.GetMinX() + 0.04434F * frame.Width, frame.GetMinY() + 0.39496F * frame.Height),
					new PointF (frame.GetMinX() + 0.03525F * frame.Width, frame.GetMinY() + 0.39149F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.02841F * frame.Width, frame.GetMinY() + 0.33867F * frame.Height),
					new PointF (frame.GetMinX() + 0.01434F * frame.Width, frame.GetMinY() + 0.37241F * frame.Height),
					new PointF (frame.GetMinX() + 0.01434F * frame.Width, frame.GetMinY() + 0.35151F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.34095F * frame.Width, frame.GetMinY() + 0.05378F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.48291F * frame.Width, frame.GetMinY() + 0.00013F * frame.Height),
					new PointF (frame.GetMinX() + 0.37888F * frame.Width, frame.GetMinY() + 0.01919F * frame.Height),
					new PointF (frame.GetMinX() + 0.42931F * frame.Width, frame.GetMinY() + 0.00013F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.62491F * frame.Width, frame.GetMinY() + 0.05378F * frame.Height),
					new PointF (frame.GetMinX() + 0.53657F * frame.Width, frame.GetMinY() + 0.00013F * frame.Height),
					new PointF (frame.GetMinX() + 0.58700F * frame.Width, frame.GetMinY() + 0.01919F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.68292F * frame.Width, frame.GetMinY() + 0.19950F * frame.Height),
					new PointF (frame.GetMinX() + 0.66705F * frame.Width, frame.GetMinY() + 0.09219F * frame.Height),
					new PointF (frame.GetMinX() + 0.68815F * frame.Width, frame.GetMinY() + 0.14529F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.68143F * frame.Width, frame.GetMinY() + 0.21454F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.69786F * frame.Width, frame.GetMinY() + 0.21318F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.71580F * frame.Width, frame.GetMinY() + 0.21244F * frame.Height),
					new PointF (frame.GetMinX() + 0.70379F * frame.Width, frame.GetMinY() + 0.21269F * frame.Height),
					new PointF (frame.GetMinX() + 0.70984F * frame.Width, frame.GetMinY() + 0.21244F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.85774F * frame.Width, frame.GetMinY() + 0.26604F * frame.Height),
					new PointF (frame.GetMinX() + 0.76941F * frame.Width, frame.GetMinY() + 0.21244F * frame.Height),
					new PointF (frame.GetMinX() + 0.81981F * frame.Width, frame.GetMinY() + 0.23147F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.85774F * frame.Width, frame.GetMinY() + 0.52485F * frame.Height),
					new PointF (frame.GetMinX() + 0.93599F * frame.Width, frame.GetMinY() + 0.33738F * frame.Height),
					new PointF (frame.GetMinX() + 0.93599F * frame.Width, frame.GetMinY() + 0.45349F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.54521F * frame.Width, frame.GetMinY() + 0.80977F * frame.Height));
				mmShapePath.AddCurveToPoint (
					new PointF (frame.GetMinX() + 0.51965F * frame.Width, frame.GetMinY() + 0.81940F * frame.Height),
					new PointF (frame.GetMinX() + 0.53840F * frame.Width, frame.GetMinY() + 0.81600F * frame.Height),
					new PointF (frame.GetMinX() + 0.52930F * frame.Width, frame.GetMinY() + 0.81940F * frame.Height));
				mmShapePath.AddLineTo (new PointF (frame.GetMinX() + 0.51965F * frame.Width, frame.GetMinY() + 0.81940F * frame.Height));
				mmShapePath.ClosePath ();
				context.SaveState ();
				context.SetShadowWithColor (mmDropShadowOffset, mmDropShadowBlurRadius, mmDropShadow.CGColor);
				context.SetBlendMode (CGBlendMode.Overlay);
				mmFill.SetFill ();
				mmShapePath.Fill ();

				RectangleF mmShapeBorderRect = RectangleF.Inflate (mmShapePath.Bounds, mmInnerShadowBlurRadius, mmInnerShadowBlurRadius);
				mmShapeBorderRect.Offset (mmInnerShadowOffset.Width, mmInnerShadowOffset.Height);
				mmShapeBorderRect.UnionWith (mmShapePath.Bounds);

				UIBezierPath mmShapeNegativePath = UIBezierPath.FromRect (mmShapeBorderRect);
				mmShapeNegativePath.AppendPath (mmShapePath);
				mmShapeNegativePath.UsesEvenOddFillRule = true;

				context.SaveState ();
				{
					Single xOffset = mmInnerShadowOffset.Width + (float) Math.Round (mmShapeBorderRect.Size.Width);
					Single yOffset = mmInnerShadowOffset.Height;
					context.SetShadowWithColor (new SizeF (xOffset + CopySign (0.1F, xOffset), yOffset + CopySign (0.1F, yOffset)), mmInnerShadowBlurRadius, mmInnerShadow.CGColor);
					mmShapePath.AddClip ();
					CGAffineTransform transform = CGAffineTransform.MakeTranslation ((float)-Math.Round (mmShapeBorderRect.Size.Width), 0F);
					mmShapeNegativePath.ApplyTransform (transform);
					UIColor.Gray.SetFill ();
					mmShapeNegativePath.Fill ();
				}
				context.RestoreState ();
				context.RestoreState ();
			}
		}

		private float CopySign(float x, float y){
			if (y < 0F) {
				return (x * -1.0F);
			} else {
				return x;
			}
		}
	}
}