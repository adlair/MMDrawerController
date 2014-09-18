using System.Drawing;
using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace MMDrawerController {

	[BaseType (typeof (UIBarButtonItem))]
	public partial interface MMDrawerBarButtonItem {

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

	public enum MMDrawerSide : [unmapped: unexposed: Elaborated] {
		None = 0,
		Left,
		Right
	}

	public enum MMDrawerSide {
		None = 0,
		Left,
		Right
	}

	public enum MMOpenDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMOpenDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMDrawerOpenCenterInteractionMode : [unmapped: unexposed: Elaborated] {
		None,
		Full,
		NavigationBarOnly
	}

	public enum MMDrawerOpenCenterInteractionMode {
		None,
		Full,
		NavigationBarOnly
	}

	[BaseType (typeof (UIViewController))]
	public partial interface MMDrawerController {

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
		IntPtr Constructor (UIViewController centerViewController, UIViewController leftDrawerViewController);

		[Export ("initWithCenterViewController:rightDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController rightDrawerViewController);

		[Export ("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated (bool animated, Delegate completion);

		[Export ("openDrawerSide:animated:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController centerViewController, bool closeAnimated, Delegate completion);

		[Export ("setCenterViewController:withFullCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController newCenterViewController, bool fullCloseAnimated, Delegate completion);

		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, Delegate completion);

		[Export ("drawerVisualStateBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 383)]
		Delegate DrawerVisualStateBlock { set; }

		[Export ("gestureCompletionBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 396)]
		Delegate GestureCompletionBlock { set; }

		[Export ("gestureShouldRecognizeTouchBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 411)]
		Delegate GestureShouldRecognizeTouchBlock { set; }
	}

	public enum MMDrawerSide : [unmapped: unexposed: Elaborated] {
		None = 0,
		Left,
		Right
	}

	public enum MMDrawerSide {
		None = 0,
		Left,
		Right
	}

	public enum MMOpenDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMOpenDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMDrawerOpenCenterInteractionMode : [unmapped: unexposed: Elaborated] {
		None,
		Full,
		NavigationBarOnly
	}

	public enum MMDrawerOpenCenterInteractionMode {
		None,
		Full,
		NavigationBarOnly
	}

	[BaseType (typeof (UIViewController))]
	public partial interface MMDrawerController {

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
		IntPtr Constructor (UIViewController centerViewController, UIViewController leftDrawerViewController);

		[Export ("initWithCenterViewController:rightDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController rightDrawerViewController);

		[Export ("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated (bool animated, Delegate completion);

		[Export ("openDrawerSide:animated:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController centerViewController, bool closeAnimated, Delegate completion);

		[Export ("setCenterViewController:withFullCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController newCenterViewController, bool fullCloseAnimated, Delegate completion);

		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, Delegate completion);

		[Export ("drawerVisualStateBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 383)]
		Delegate DrawerVisualStateBlock { set; }

		[Export ("gestureCompletionBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 396)]
		Delegate GestureCompletionBlock { set; }

		[Export ("gestureShouldRecognizeTouchBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 411)]
		Delegate GestureShouldRecognizeTouchBlock { set; }
	}

	[Category, BaseType (typeof (MMDrawerController))]
	public partial interface Subclass_MMDrawerController {

		[Export ("tapGestureCallback:")]
		void TapGestureCallback (UITapGestureRecognizer tapGesture);

		[Export ("panGestureCallback:")]
		void PanGestureCallback (UIPanGestureRecognizer panGesture);

		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UITouch touch);

		[Export ("prepareToPresentDrawer:animated:")]
		void PrepareToPresentDrawer (MMDrawerSide drawer, bool animated);

		[Export ("closeDrawerAnimated:velocity:animationOptions:completion:")]
		void CloseDrawerAnimated (bool animated, float velocity, UIViewAnimationOptions options, Delegate completion);

		[Export ("openDrawerSide:animated:velocity:animationOptions:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, float velocity, UIViewAnimationOptions options, Delegate completion);

		[Export ("willRotateToInterfaceOrientation:duration:")]
		void WillRotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);

		[Export ("willAnimateRotationToInterfaceOrientation:duration:")]
		void WillAnimateRotationToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);
	}

	public enum MMDrawerSide : [unmapped: unexposed: Elaborated] {
		None = 0,
		Left,
		Right
	}

	public enum MMDrawerSide {
		None = 0,
		Left,
		Right
	}

	public enum MMOpenDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMOpenDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMDrawerOpenCenterInteractionMode : [unmapped: unexposed: Elaborated] {
		None,
		Full,
		NavigationBarOnly
	}

	public enum MMDrawerOpenCenterInteractionMode {
		None,
		Full,
		NavigationBarOnly
	}

	[BaseType (typeof (UIViewController))]
	public partial interface MMDrawerController {

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
		IntPtr Constructor (UIViewController centerViewController, UIViewController leftDrawerViewController);

		[Export ("initWithCenterViewController:rightDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController rightDrawerViewController);

		[Export ("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated (bool animated, Delegate completion);

		[Export ("openDrawerSide:animated:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController centerViewController, bool closeAnimated, Delegate completion);

		[Export ("setCenterViewController:withFullCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController newCenterViewController, bool fullCloseAnimated, Delegate completion);

		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, Delegate completion);

		[Export ("drawerVisualStateBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 383)]
		Delegate DrawerVisualStateBlock { set; }

		[Export ("gestureCompletionBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 396)]
		Delegate GestureCompletionBlock { set; }

		[Export ("gestureShouldRecognizeTouchBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 411)]
		Delegate GestureShouldRecognizeTouchBlock { set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface MMDrawerVisualState {

		[Export ("slideAndScaleVisualStateBlock"), Verify ("ObjC method massaged into getter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerVisualState.h", Line = 36)]
		MMDrawerControllerDrawerVisualStateBlock SlideAndScaleVisualStateBlock { get; }

		[Export ("slideVisualStateBlock"), Verify ("ObjC method massaged into getter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerVisualState.h", Line = 43)]
		MMDrawerControllerDrawerVisualStateBlock SlideVisualStateBlock { get; }

		[Export ("swingingDoorVisualStateBlock"), Verify ("ObjC method massaged into getter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerVisualState.h", Line = 50)]
		MMDrawerControllerDrawerVisualStateBlock SwingingDoorVisualStateBlock { get; }

		[Export ("parallaxVisualStateBlockWithParallaxFactor:")]
		MMDrawerControllerDrawerVisualStateBlock ParallaxVisualStateBlockWithParallaxFactor (float parallaxFactor);
	}

	public enum MMDrawerSide : [unmapped: unexposed: Elaborated] {
		None = 0,
		Left,
		Right
	}

	public enum MMDrawerSide {
		None = 0,
		Left,
		Right
	}

	public enum MMOpenDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMOpenDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = MMOpenDrawerGestureModePanningNavigationBar | MMOpenDrawerGestureModePanningCenterView | MMOpenDrawerGestureModeBezelPanningCenterView | MMOpenDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode : [unmapped: unexposed: Elaborated] {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMCloseDrawerGestureMode {
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = MMCloseDrawerGestureModePanningNavigationBar | MMCloseDrawerGestureModePanningCenterView | MMCloseDrawerGestureModeBezelPanningCenterView | MMCloseDrawerGestureModeTapNavigationBar | MMCloseDrawerGestureModeTapCenterView | MMCloseDrawerGestureModePanningDrawerView | MMCloseDrawerGestureModeCustom
	}

	public enum MMDrawerOpenCenterInteractionMode : [unmapped: unexposed: Elaborated] {
		None,
		Full,
		NavigationBarOnly
	}

	public enum MMDrawerOpenCenterInteractionMode {
		None,
		Full,
		NavigationBarOnly
	}

	[BaseType (typeof (UIViewController))]
	public partial interface MMDrawerController {

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
		IntPtr Constructor (UIViewController centerViewController, UIViewController leftDrawerViewController);

		[Export ("initWithCenterViewController:rightDrawerViewController:")]
		IntPtr Constructor (UIViewController centerViewController, UIViewController rightDrawerViewController);

		[Export ("toggleDrawerSide:animated:completion:")]
		void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("closeDrawerAnimated:completion:")]
		void CloseDrawerAnimated (bool animated, Delegate completion);

		[Export ("openDrawerSide:animated:completion:")]
		void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, Delegate completion);

		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController centerViewController, bool closeAnimated, Delegate completion);

		[Export ("setCenterViewController:withFullCloseAnimation:completion:")]
		void SetCenterViewController (UIViewController newCenterViewController, bool fullCloseAnimated, Delegate completion);

		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		void SetMaximumLeftDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		void SetMaximumRightDrawerWidth (float width, bool animated, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, Delegate completion);

		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, Delegate completion);

		[Export ("drawerVisualStateBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 383)]
		Delegate DrawerVisualStateBlock { set; }

		[Export ("gestureCompletionBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 396)]
		Delegate GestureCompletionBlock { set; }

		[Export ("gestureShouldRecognizeTouchBlock"), Verify ("ObjC method massaged into setter property", "/Users/adlair/Xamarin-Bindings/MMDrawerController/extern/MMDrawerController.h", Line = 411)]
		Delegate GestureShouldRecognizeTouchBlock { set; }
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface MMDrawerController_UIViewController {

		[Export ("mm_drawerController", ArgumentSemantic.Retain)]
		MMDrawerController Mm_drawerController { get; }

		[Export ("mm_visibleDrawerFrame", ArgumentSemantic.Assign)]
		RectangleF Mm_visibleDrawerFrame { get; }
	}
}
