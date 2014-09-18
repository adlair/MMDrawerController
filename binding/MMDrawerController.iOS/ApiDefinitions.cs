using System.Drawing;
using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace MMDrawerController
{
	[BaseType (typeof(UIBarButtonItem))]
	public partial interface MMDrawerBarButtonItem
	{
		[Export ("initWithTarget:action:")]
		IntPtr Constructor (NSObject target, Selector action);

		[Export ("menuButtonColorForState:")]
		UIColor MenuButtonColorForState (UIControlState state);

		[Export ("setMenuButtonColor:forState:")]
		void SetMenuButtonColor (UIColor color, UIControlState state);

		[Export ("shadowColorForState:")]
		UIColor ShadowColorForState (UIControlState state);

		[Export ("setShadowColor:forState:")]
		void SetShadowColor (UIColor color, UIControlState state);
	}



	[BaseType (typeof(UIViewController))]
	public partial interface MMDrawerController
	{
		[Export ("centerViewController", ArgumentSemantic.Retain)]
		UIViewController CenterViewController { get; set; }

		[Export ("leftDrawerViewController", ArgumentSemantic.Retain)]
		UIViewController LeftDrawerViewController { get; set; }

		[Export ("rightDrawerViewController", ArgumentSemantic.Retain)]
		UIViewController RightDrawerViewController { get; set; }

		[Export ("maximumLeftDrawerWidth")]
		float MaximumLeftDrawerWidth { get; set; }

		[Export ("maximumRightDrawerWidth")]
		float MaximumRightDrawerWidth { get; set; }

		[Export ("visibleLeftDrawerWidth")]
		float VisibleLeftDrawerWidth { get; }

		[Export ("visibleRightDrawerWidth")]
		float VisibleRightDrawerWidth { get; }

		[Export ("animationVelocity")]
		float AnimationVelocity { get; set; }

		[Export ("shouldStretchDrawer")]
		bool ShouldStretchDrawer { get; set; }

		[Export ("openSide")]
		MMDrawerSide OpenSide { get; }

		[Export ("openDrawerGestureModeMask")]
		MMOpenDrawerGestureMode OpenDrawerGestureModeMask { get; set; }

		[Export ("closeDrawerGestureModeMask")]
		MMCloseDrawerGestureMode CloseDrawerGestureModeMask { get; set; }

		[Export ("centerHiddenInteractionMode")]
		MMDrawerOpenCenterInteractionMode CenterHiddenInteractionMode { get; set; }

		[Export ("showsShadow")]
		bool ShowsShadow { get; set; }

		[Export ("showsStatusBarBackgroundView")]
		bool ShowsStatusBarBackgroundView { get; set; }

		[Export ("statusBarViewBackgroundColor", ArgumentSemantic.Retain)]
		UIColor StatusBarViewBackgroundColor { get; set; }

		[Export ("initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController leftDrawerViewController, UIViewController rightDrawerViewController);

		[Export ("initWithCenterViewController:leftDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController drawerViewController);

		[Export ("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, Action completion);

		[Export ("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated (bool animated, Action completion);

		[Export ("openDrawerSide:animated:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, Action completion);

		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController centerViewController, bool closeAnimated, Action completion);

		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth (float width, bool animated, Action completion);

		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth (float width, bool animated, Action completion);

		[Export ("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, Action completion);

		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, Action completion);

		[Export ("drawerVisualStateBlock")]
		Action DrawerVisualStateBlock { set; }

		[Export ("gestureCompletionBlock")]
		Action GestureCompletionBlock { set; }
	}

	[Category, BaseType (typeof(MMDrawerController))]
	public partial interface Subclass_MMDrawerController
	{
		[Export ("tapGestureCallback:")]
		void TapGestureCallback (UITapGestureRecognizer tapGesture);

		[Export ("panGestureCallback:")]
		void PanGestureCallback (UIPanGestureRecognizer panGesture);

		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UITouch touch);

		[Export ("prepareToPresentDrawer:animated:")]
		void PrepareToPresentDrawer (MMDrawerSide drawer, bool animated);

		[Export ("closeDrawerAnimated:velocity:animationOptions:completion:")]
		void CloseDrawerAnimated (bool animated, float velocity, UIViewAnimationOptions options, Action completion);

		[Export ("openDrawerSide:animated:velocity:animationOptions:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, float velocity, UIViewAnimationOptions options, Action Completion);

		[Export ("willRotateToInterfaceOrientation:duration:")]
		void WillRotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);

		[Export ("willAnimateRotationToInterfaceOrientation:duration:")]
		void WillAnimateRotationToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);


	}

	[Category, BaseType (typeof(UIViewController))]
	public partial interface MMDrawerController_UIViewController
	{
		[Static, Export ("mm_drawerController", ArgumentSemantic.Retain)]
		MMDrawerController Mm_drawerController { get; }

		[Static, Export ("mm_visibleDrawerFrame", ArgumentSemantic.Assign)]
		RectangleF Mm_visibleDrawerFrame { get; }
	}
}