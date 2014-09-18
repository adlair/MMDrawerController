//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace MMDrawerController {
	[Register("MMDrawerController", true)]
	public unsafe partial class MMDrawerController : global::MonoTouch.UIKit.UIViewController {
		[CompilerGenerated]
		const string selAnimationVelocity = "animationVelocity";
		static readonly IntPtr selAnimationVelocityHandle = Selector.GetHandle ("animationVelocity");
		[CompilerGenerated]
		const string selBouncePreviewForDrawerSideCompletion_ = "bouncePreviewForDrawerSide:completion:";
		static readonly IntPtr selBouncePreviewForDrawerSideCompletion_Handle = Selector.GetHandle ("bouncePreviewForDrawerSide:completion:");
		[CompilerGenerated]
		const string selBouncePreviewForDrawerSideDistanceCompletion_ = "bouncePreviewForDrawerSide:distance:completion:";
		static readonly IntPtr selBouncePreviewForDrawerSideDistanceCompletion_Handle = Selector.GetHandle ("bouncePreviewForDrawerSide:distance:completion:");
		[CompilerGenerated]
		const string selCenterHiddenInteractionMode = "centerHiddenInteractionMode";
		static readonly IntPtr selCenterHiddenInteractionModeHandle = Selector.GetHandle ("centerHiddenInteractionMode");
		[CompilerGenerated]
		const string selCenterViewController = "centerViewController";
		static readonly IntPtr selCenterViewControllerHandle = Selector.GetHandle ("centerViewController");
		[CompilerGenerated]
		const string selCloseDrawerAnimatedCompletion_ = "closeDrawerAnimated:completion:";
		static readonly IntPtr selCloseDrawerAnimatedCompletion_Handle = Selector.GetHandle ("closeDrawerAnimated:completion:");
		[CompilerGenerated]
		const string selCloseDrawerGestureModeMask = "closeDrawerGestureModeMask";
		static readonly IntPtr selCloseDrawerGestureModeMaskHandle = Selector.GetHandle ("closeDrawerGestureModeMask");
		[CompilerGenerated]
		const string selInitWithCenterViewControllerLeftDrawerViewController_ = "initWithCenterViewController:leftDrawerViewController:";
		static readonly IntPtr selInitWithCenterViewControllerLeftDrawerViewController_Handle = Selector.GetHandle ("initWithCenterViewController:leftDrawerViewController:");
		[CompilerGenerated]
		const string selInitWithCenterViewControllerLeftDrawerViewControllerRightDrawerViewController_ = "initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:";
		static readonly IntPtr selInitWithCenterViewControllerLeftDrawerViewControllerRightDrawerViewController_Handle = Selector.GetHandle ("initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:");
		[CompilerGenerated]
		const string selLeftDrawerViewController = "leftDrawerViewController";
		static readonly IntPtr selLeftDrawerViewControllerHandle = Selector.GetHandle ("leftDrawerViewController");
		[CompilerGenerated]
		const string selMaximumLeftDrawerWidth = "maximumLeftDrawerWidth";
		static readonly IntPtr selMaximumLeftDrawerWidthHandle = Selector.GetHandle ("maximumLeftDrawerWidth");
		[CompilerGenerated]
		const string selMaximumRightDrawerWidth = "maximumRightDrawerWidth";
		static readonly IntPtr selMaximumRightDrawerWidthHandle = Selector.GetHandle ("maximumRightDrawerWidth");
		[CompilerGenerated]
		const string selOpenDrawerGestureModeMask = "openDrawerGestureModeMask";
		static readonly IntPtr selOpenDrawerGestureModeMaskHandle = Selector.GetHandle ("openDrawerGestureModeMask");
		[CompilerGenerated]
		const string selOpenDrawerSideAnimatedCompletion_ = "openDrawerSide:animated:completion:";
		static readonly IntPtr selOpenDrawerSideAnimatedCompletion_Handle = Selector.GetHandle ("openDrawerSide:animated:completion:");
		[CompilerGenerated]
		const string selOpenSide = "openSide";
		static readonly IntPtr selOpenSideHandle = Selector.GetHandle ("openSide");
		[CompilerGenerated]
		const string selRightDrawerViewController = "rightDrawerViewController";
		static readonly IntPtr selRightDrawerViewControllerHandle = Selector.GetHandle ("rightDrawerViewController");
		[CompilerGenerated]
		const string selSetAnimationVelocity_ = "setAnimationVelocity:";
		static readonly IntPtr selSetAnimationVelocity_Handle = Selector.GetHandle ("setAnimationVelocity:");
		[CompilerGenerated]
		const string selSetCenterHiddenInteractionMode_ = "setCenterHiddenInteractionMode:";
		static readonly IntPtr selSetCenterHiddenInteractionMode_Handle = Selector.GetHandle ("setCenterHiddenInteractionMode:");
		[CompilerGenerated]
		const string selSetCenterViewController_ = "setCenterViewController:";
		static readonly IntPtr selSetCenterViewController_Handle = Selector.GetHandle ("setCenterViewController:");
		[CompilerGenerated]
		const string selSetCenterViewControllerWithCloseAnimationCompletion_ = "setCenterViewController:withCloseAnimation:completion:";
		static readonly IntPtr selSetCenterViewControllerWithCloseAnimationCompletion_Handle = Selector.GetHandle ("setCenterViewController:withCloseAnimation:completion:");
		[CompilerGenerated]
		const string selSetCloseDrawerGestureModeMask_ = "setCloseDrawerGestureModeMask:";
		static readonly IntPtr selSetCloseDrawerGestureModeMask_Handle = Selector.GetHandle ("setCloseDrawerGestureModeMask:");
		[CompilerGenerated]
		const string selSetDrawerVisualStateBlock_ = "setDrawerVisualStateBlock:";
		static readonly IntPtr selSetDrawerVisualStateBlock_Handle = Selector.GetHandle ("setDrawerVisualStateBlock:");
		[CompilerGenerated]
		const string selSetGestureCompletionBlock_ = "setGestureCompletionBlock:";
		static readonly IntPtr selSetGestureCompletionBlock_Handle = Selector.GetHandle ("setGestureCompletionBlock:");
		[CompilerGenerated]
		const string selSetLeftDrawerViewController_ = "setLeftDrawerViewController:";
		static readonly IntPtr selSetLeftDrawerViewController_Handle = Selector.GetHandle ("setLeftDrawerViewController:");
		[CompilerGenerated]
		const string selSetMaximumLeftDrawerWidth_ = "setMaximumLeftDrawerWidth:";
		static readonly IntPtr selSetMaximumLeftDrawerWidth_Handle = Selector.GetHandle ("setMaximumLeftDrawerWidth:");
		[CompilerGenerated]
		const string selSetMaximumLeftDrawerWidthAnimatedCompletion_ = "setMaximumLeftDrawerWidth:animated:completion:";
		static readonly IntPtr selSetMaximumLeftDrawerWidthAnimatedCompletion_Handle = Selector.GetHandle ("setMaximumLeftDrawerWidth:animated:completion:");
		[CompilerGenerated]
		const string selSetMaximumRightDrawerWidth_ = "setMaximumRightDrawerWidth:";
		static readonly IntPtr selSetMaximumRightDrawerWidth_Handle = Selector.GetHandle ("setMaximumRightDrawerWidth:");
		[CompilerGenerated]
		const string selSetMaximumRightDrawerWidthAnimatedCompletion_ = "setMaximumRightDrawerWidth:animated:completion:";
		static readonly IntPtr selSetMaximumRightDrawerWidthAnimatedCompletion_Handle = Selector.GetHandle ("setMaximumRightDrawerWidth:animated:completion:");
		[CompilerGenerated]
		const string selSetOpenDrawerGestureModeMask_ = "setOpenDrawerGestureModeMask:";
		static readonly IntPtr selSetOpenDrawerGestureModeMask_Handle = Selector.GetHandle ("setOpenDrawerGestureModeMask:");
		[CompilerGenerated]
		const string selSetRightDrawerViewController_ = "setRightDrawerViewController:";
		static readonly IntPtr selSetRightDrawerViewController_Handle = Selector.GetHandle ("setRightDrawerViewController:");
		[CompilerGenerated]
		const string selSetShouldStretchDrawer_ = "setShouldStretchDrawer:";
		static readonly IntPtr selSetShouldStretchDrawer_Handle = Selector.GetHandle ("setShouldStretchDrawer:");
		[CompilerGenerated]
		const string selSetShowsShadow_ = "setShowsShadow:";
		static readonly IntPtr selSetShowsShadow_Handle = Selector.GetHandle ("setShowsShadow:");
		[CompilerGenerated]
		const string selSetShowsStatusBarBackgroundView_ = "setShowsStatusBarBackgroundView:";
		static readonly IntPtr selSetShowsStatusBarBackgroundView_Handle = Selector.GetHandle ("setShowsStatusBarBackgroundView:");
		[CompilerGenerated]
		const string selSetStatusBarViewBackgroundColor_ = "setStatusBarViewBackgroundColor:";
		static readonly IntPtr selSetStatusBarViewBackgroundColor_Handle = Selector.GetHandle ("setStatusBarViewBackgroundColor:");
		[CompilerGenerated]
		const string selShouldStretchDrawer = "shouldStretchDrawer";
		static readonly IntPtr selShouldStretchDrawerHandle = Selector.GetHandle ("shouldStretchDrawer");
		[CompilerGenerated]
		const string selShowsShadow = "showsShadow";
		static readonly IntPtr selShowsShadowHandle = Selector.GetHandle ("showsShadow");
		[CompilerGenerated]
		const string selShowsStatusBarBackgroundView = "showsStatusBarBackgroundView";
		static readonly IntPtr selShowsStatusBarBackgroundViewHandle = Selector.GetHandle ("showsStatusBarBackgroundView");
		[CompilerGenerated]
		const string selStatusBarViewBackgroundColor = "statusBarViewBackgroundColor";
		static readonly IntPtr selStatusBarViewBackgroundColorHandle = Selector.GetHandle ("statusBarViewBackgroundColor");
		[CompilerGenerated]
		const string selToggleDrawerSideAnimatedCompletion_ = "toggleDrawerSide:animated:completion:";
		static readonly IntPtr selToggleDrawerSideAnimatedCompletion_Handle = Selector.GetHandle ("toggleDrawerSide:animated:completion:");
		[CompilerGenerated]
		const string selVisibleLeftDrawerWidth = "visibleLeftDrawerWidth";
		static readonly IntPtr selVisibleLeftDrawerWidthHandle = Selector.GetHandle ("visibleLeftDrawerWidth");
		[CompilerGenerated]
		const string selVisibleRightDrawerWidth = "visibleRightDrawerWidth";
		static readonly IntPtr selVisibleRightDrawerWidthHandle = Selector.GetHandle ("visibleRightDrawerWidth");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MMDrawerController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MMDrawerController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MMDrawerController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMDrawerController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMDrawerController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:")]
		[CompilerGenerated]
		public MMDrawerController (global::MonoTouch.UIKit.UIViewController centerViewController, global::MonoTouch.UIKit.UIViewController leftDrawerViewController, global::MonoTouch.UIKit.UIViewController rightDrawerViewController)
			: base (NSObjectFlag.Empty)
		{
			if (centerViewController == null)
				throw new ArgumentNullException ("centerViewController");
			if (leftDrawerViewController == null)
				throw new ArgumentNullException ("leftDrawerViewController");
			if (rightDrawerViewController == null)
				throw new ArgumentNullException ("rightDrawerViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithCenterViewControllerLeftDrawerViewControllerRightDrawerViewController_Handle, centerViewController.Handle, leftDrawerViewController.Handle, rightDrawerViewController.Handle), "initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithCenterViewControllerLeftDrawerViewControllerRightDrawerViewController_Handle, centerViewController.Handle, leftDrawerViewController.Handle, rightDrawerViewController.Handle), "initWithCenterViewController:leftDrawerViewController:rightDrawerViewController:");
			}
		}
		
		[Export ("initWithCenterViewController:leftDrawerViewController:")]
		[CompilerGenerated]
		public MMDrawerController (global::MonoTouch.UIKit.UIViewController centerViewController, global::MonoTouch.UIKit.UIViewController drawerViewController)
			: base (NSObjectFlag.Empty)
		{
			if (centerViewController == null)
				throw new ArgumentNullException ("centerViewController");
			if (drawerViewController == null)
				throw new ArgumentNullException ("drawerViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithCenterViewControllerLeftDrawerViewController_Handle, centerViewController.Handle, drawerViewController.Handle), "initWithCenterViewController:leftDrawerViewController:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithCenterViewControllerLeftDrawerViewController_Handle, centerViewController.Handle, drawerViewController.Handle), "initWithCenterViewController:leftDrawerViewController:");
			}
		}
		
		[Export ("bouncePreviewForDrawerSide:completion:")]
		[CompilerGenerated]
		public unsafe virtual void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selBouncePreviewForDrawerSideCompletion_Handle, (int)drawerSide, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selBouncePreviewForDrawerSideCompletion_Handle, (int)drawerSide, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("bouncePreviewForDrawerSide:distance:completion:")]
		[CompilerGenerated]
		public unsafe virtual void BouncePreviewForDrawerSide (MMDrawerSide drawerSide, float distance, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_int_float_IntPtr (this.Handle, selBouncePreviewForDrawerSideDistanceCompletion_Handle, (int)drawerSide, distance, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_int_float_IntPtr (this.SuperHandle, selBouncePreviewForDrawerSideDistanceCompletion_Handle, (int)drawerSide, distance, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("closeDrawerAnimated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void CloseDrawerAnimated (bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selCloseDrawerAnimatedCompletion_Handle, animated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selCloseDrawerAnimatedCompletion_Handle, animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("openDrawerSide:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void OpenDrawerSide (MMDrawerSide drawerSide, bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_int_bool_IntPtr (this.Handle, selOpenDrawerSideAnimatedCompletion_Handle, (int)drawerSide, animated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_int_bool_IntPtr (this.SuperHandle, selOpenDrawerSideAnimatedCompletion_Handle, (int)drawerSide, animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setCenterViewController:withCloseAnimation:completion:")]
		[CompilerGenerated]
		public unsafe virtual void SetCenterViewController (global::MonoTouch.UIKit.UIViewController centerViewController, bool closeAnimated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (centerViewController == null)
				throw new ArgumentNullException ("centerViewController");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, selSetCenterViewControllerWithCloseAnimationCompletion_Handle, centerViewController.Handle, closeAnimated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, selSetCenterViewControllerWithCloseAnimationCompletion_Handle, centerViewController.Handle, closeAnimated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setMaximumLeftDrawerWidth:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void SetMaximumLeftDrawerWidth (float width, bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_float_bool_IntPtr (this.Handle, selSetMaximumLeftDrawerWidthAnimatedCompletion_Handle, width, animated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_float_bool_IntPtr (this.SuperHandle, selSetMaximumLeftDrawerWidthAnimatedCompletion_Handle, width, animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("setMaximumRightDrawerWidth:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void SetMaximumRightDrawerWidth (float width, bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_float_bool_IntPtr (this.Handle, selSetMaximumRightDrawerWidthAnimatedCompletion_Handle, width, animated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_float_bool_IntPtr (this.SuperHandle, selSetMaximumRightDrawerWidthAnimatedCompletion_Handle, width, animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("toggleDrawerSide:animated:completion:")]
		[CompilerGenerated]
		public unsafe virtual void ToggleDrawerSide (MMDrawerSide drawerSide, bool animated, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_int_bool_IntPtr (this.Handle, selToggleDrawerSideAnimatedCompletion_Handle, (int)drawerSide, animated, (IntPtr) block_ptr_completion);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_int_bool_IntPtr (this.SuperHandle, selToggleDrawerSideAnimatedCompletion_Handle, (int)drawerSide, animated, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual float AnimationVelocity {
			[Export ("animationVelocity")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, selAnimationVelocityHandle);
				} else {
					return ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAnimationVelocityHandle);
				}
			}
			
			[Export ("setAnimationVelocity:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_float (this.Handle, selSetAnimationVelocity_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAnimationVelocity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMDrawerOpenCenterInteractionMode CenterHiddenInteractionMode {
			[Export ("centerHiddenInteractionMode")]
			get {
				if (IsDirectBinding) {
					return (MMDrawerOpenCenterInteractionMode) ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, selCenterHiddenInteractionModeHandle);
				} else {
					return (MMDrawerOpenCenterInteractionMode) ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCenterHiddenInteractionModeHandle);
				}
			}
			
			[Export ("setCenterHiddenInteractionMode:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, selSetCenterHiddenInteractionMode_Handle, (int)value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetCenterHiddenInteractionMode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_CenterViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController CenterViewController {
			[Export ("centerViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, selCenterViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCenterViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CenterViewController_var = ret;
				return ret;
			}
			
			[Export ("setCenterViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCenterViewController_Handle, value.Handle);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCenterViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CenterViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual MMCloseDrawerGestureMode CloseDrawerGestureModeMask {
			[Export ("closeDrawerGestureModeMask")]
			get {
				if (IsDirectBinding) {
					return (MMCloseDrawerGestureMode) ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, selCloseDrawerGestureModeMaskHandle);
				} else {
					return (MMCloseDrawerGestureMode) ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCloseDrawerGestureModeMaskHandle);
				}
			}
			
			[Export ("setCloseDrawerGestureModeMask:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, selSetCloseDrawerGestureModeMask_Handle, (int)value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetCloseDrawerGestureModeMask_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual global::System.Action DrawerVisualStateBlock {
			[Export ("setDrawerVisualStateBlock:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDAction.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDrawerVisualStateBlock_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDrawerVisualStateBlock_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual global::System.Action GestureCompletionBlock {
			[Export ("setGestureCompletionBlock:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDAction.Handler, value);
				
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGestureCompletionBlock_Handle, (IntPtr) block_ptr_value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGestureCompletionBlock_Handle, (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_LeftDrawerViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController LeftDrawerViewController {
			[Export ("leftDrawerViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, selLeftDrawerViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLeftDrawerViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftDrawerViewController_var = ret;
				return ret;
			}
			
			[Export ("setLeftDrawerViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLeftDrawerViewController_Handle, value.Handle);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLeftDrawerViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftDrawerViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumLeftDrawerWidth {
			[Export ("maximumLeftDrawerWidth")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, selMaximumLeftDrawerWidthHandle);
				} else {
					return ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumLeftDrawerWidthHandle);
				}
			}
			
			[Export ("setMaximumLeftDrawerWidth:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumLeftDrawerWidth_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMaximumLeftDrawerWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MaximumRightDrawerWidth {
			[Export ("maximumRightDrawerWidth")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, selMaximumRightDrawerWidthHandle);
				} else {
					return ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, selMaximumRightDrawerWidthHandle);
				}
			}
			
			[Export ("setMaximumRightDrawerWidth:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_float (this.Handle, selSetMaximumRightDrawerWidth_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetMaximumRightDrawerWidth_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMOpenDrawerGestureMode OpenDrawerGestureModeMask {
			[Export ("openDrawerGestureModeMask")]
			get {
				if (IsDirectBinding) {
					return (MMOpenDrawerGestureMode) ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, selOpenDrawerGestureModeMaskHandle);
				} else {
					return (MMOpenDrawerGestureMode) ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, selOpenDrawerGestureModeMaskHandle);
				}
			}
			
			[Export ("setOpenDrawerGestureModeMask:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, selSetOpenDrawerGestureModeMask_Handle, (int)value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetOpenDrawerGestureModeMask_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMDrawerSide OpenSide {
			[Export ("openSide")]
			get {
				if (IsDirectBinding) {
					return (MMDrawerSide) ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, selOpenSideHandle);
				} else {
					return (MMDrawerSide) ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, selOpenSideHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RightDrawerViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RightDrawerViewController {
			[Export ("rightDrawerViewController", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, selRightDrawerViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRightDrawerViewControllerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightDrawerViewController_var = ret;
				return ret;
			}
			
			[Export ("setRightDrawerViewController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRightDrawerViewController_Handle, value.Handle);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRightDrawerViewController_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightDrawerViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldStretchDrawer {
			[Export ("shouldStretchDrawer")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, selShouldStretchDrawerHandle);
				} else {
					return ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldStretchDrawerHandle);
				}
			}
			
			[Export ("setShouldStretchDrawer:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldStretchDrawer_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldStretchDrawer_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsShadow {
			[Export ("showsShadow")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, selShowsShadowHandle);
				} else {
					return ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowsShadowHandle);
				}
			}
			
			[Export ("setShowsShadow:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsShadow_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowsShadow_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsStatusBarBackgroundView {
			[Export ("showsStatusBarBackgroundView")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, selShowsStatusBarBackgroundViewHandle);
				} else {
					return ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowsStatusBarBackgroundViewHandle);
				}
			}
			
			[Export ("setShowsStatusBarBackgroundView:")]
			set {
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsStatusBarBackgroundView_Handle, value);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowsStatusBarBackgroundView_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_StatusBarViewBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor StatusBarViewBackgroundColor {
			[Export ("statusBarViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusBarViewBackgroundColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStatusBarViewBackgroundColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_StatusBarViewBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setStatusBarViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStatusBarViewBackgroundColor_Handle, value.Handle);
				} else {
					ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStatusBarViewBackgroundColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_StatusBarViewBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float VisibleLeftDrawerWidth {
			[Export ("visibleLeftDrawerWidth")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, selVisibleLeftDrawerWidthHandle);
				} else {
					return ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, selVisibleLeftDrawerWidthHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float VisibleRightDrawerWidth {
			[Export ("visibleRightDrawerWidth")]
			get {
				if (IsDirectBinding) {
					return ApiDefinitions.Messaging.float_objc_msgSend (this.Handle, selVisibleRightDrawerWidthHandle);
				} else {
					return ApiDefinitions.Messaging.float_objc_msgSendSuper (this.SuperHandle, selVisibleRightDrawerWidthHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CenterViewController_var = null;
				__mt_LeftDrawerViewController_var = null;
				__mt_RightDrawerViewController_var = null;
				__mt_StatusBarViewBackgroundColor_var = null;
			}
		}
	} /* class MMDrawerController */
}
