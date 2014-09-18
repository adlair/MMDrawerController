using System;
using MonoTouch.Foundation;

using MMDrawerController;

namespace MMDrawerControllerKitchenSink
{
	public class MMExampleDrawerVisualStateManager : NSObject
	{
		public enum MMDrawerAnimationType{
			None,
			Slide,
			SlideAndScale,
			SwingingDoor,
			Parallax
		}

		public MMDrawerAnimationType LeftDrawerAnimationType {
			get;
			set;
		}

		public MMDrawerAnimationType RightDrawerAnimationType {
			get;
			set;
		}

		public MMExampleDrawerVisualStateManager ()
		{
		}


	}
}

