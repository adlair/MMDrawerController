using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MMDrawerControllerKitchenSink
{
	public class MMSideDrawerSectionHeaderView : UIView
	{
		public NSString title {
			get;
			set;
		}

		public MMSideDrawerSectionHeaderView (RectangleF frame)
		{
			this.Init ();
			this.Frame = frame;
		}
	}
}

