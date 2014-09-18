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
	public unsafe static partial class Subclass_MMDrawerController  {
		[CompilerGenerated]
		const string selCloseDrawerAnimatedVelocityAnimationOptionsCompletion_ = "closeDrawerAnimated:velocity:animationOptions:completion:";
		static readonly IntPtr selCloseDrawerAnimatedVelocityAnimationOptionsCompletion_Handle = Selector.GetHandle ("closeDrawerAnimated:velocity:animationOptions:completion:");
		[CompilerGenerated]
		const string selGestureRecognizerShouldReceiveTouch_ = "gestureRecognizer:shouldReceiveTouch:";
		static readonly IntPtr selGestureRecognizerShouldReceiveTouch_Handle = Selector.GetHandle ("gestureRecognizer:shouldReceiveTouch:");
		[CompilerGenerated]
		const string selOpenDrawerSideAnimatedVelocityAnimationOptionsCompletion_ = "openDrawerSide:animated:velocity:animationOptions:completion:";
		static readonly IntPtr selOpenDrawerSideAnimatedVelocityAnimationOptionsCompletion_Handle = Selector.GetHandle ("openDrawerSide:animated:velocity:animationOptions:completion:");
		[CompilerGenerated]
		const string selPanGestureCallback_ = "panGestureCallback:";
		static readonly IntPtr selPanGestureCallback_Handle = Selector.GetHandle ("panGestureCallback:");
		[CompilerGenerated]
		const string selPrepareToPresentDrawerAnimated_ = "prepareToPresentDrawer:animated:";
		static readonly IntPtr selPrepareToPresentDrawerAnimated_Handle = Selector.GetHandle ("prepareToPresentDrawer:animated:");
		[CompilerGenerated]
		const string selTapGestureCallback_ = "tapGestureCallback:";
		static readonly IntPtr selTapGestureCallback_Handle = Selector.GetHandle ("tapGestureCallback:");
		[CompilerGenerated]
		const string selWillAnimateRotationToInterfaceOrientationDuration_ = "willAnimateRotationToInterfaceOrientation:duration:";
		static readonly IntPtr selWillAnimateRotationToInterfaceOrientationDuration_Handle = Selector.GetHandle ("willAnimateRotationToInterfaceOrientation:duration:");
		[CompilerGenerated]
		const string selWillRotateToInterfaceOrientationDuration_ = "willRotateToInterfaceOrientation:duration:";
		static readonly IntPtr selWillRotateToInterfaceOrientationDuration_Handle = Selector.GetHandle ("willRotateToInterfaceOrientation:duration:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MMDrawerController.MMDrawerController");
		
		[Export ("closeDrawerAnimated:velocity:animationOptions:completion:")]
		[CompilerGenerated]
		public unsafe static void CloseDrawerAnimated (this MMDrawerController This, bool animated, float velocity, global::MonoTouch.UIKit.UIViewAnimationOptions options, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			ApiDefinitions.Messaging.void_objc_msgSend_bool_float_int_IntPtr (This.Handle, selCloseDrawerAnimatedVelocityAnimationOptionsCompletion_Handle, animated, velocity, (int)options, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		[CompilerGenerated]
		public static bool GestureRecognizer (this MMDrawerController This, global::MonoTouch.UIKit.UIGestureRecognizer gestureRecognizer, global::MonoTouch.UIKit.UITouch touch)
		{
			if (gestureRecognizer == null)
				throw new ArgumentNullException ("gestureRecognizer");
			if (touch == null)
				throw new ArgumentNullException ("touch");
			return ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, selGestureRecognizerShouldReceiveTouch_Handle, gestureRecognizer.Handle, touch.Handle);
		}
		
		[Export ("openDrawerSide:animated:velocity:animationOptions:completion:")]
		[CompilerGenerated]
		public unsafe static void OpenDrawerSide (this MMDrawerController This, MMDrawerSide drawerSide, bool animated, float velocity, global::MonoTouch.UIKit.UIViewAnimationOptions options, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDAction))]global::System.Action Completion)
		{
			if (Completion == null)
				throw new ArgumentNullException ("Completion");
			BlockLiteral *block_ptr_Completion;
			BlockLiteral block_Completion;
			block_Completion = new BlockLiteral ();
			block_ptr_Completion = &block_Completion;
			block_Completion.SetupBlock (Trampolines.SDAction.Handler, Completion);
			
			ApiDefinitions.Messaging.void_objc_msgSend_int_bool_float_int_IntPtr (This.Handle, selOpenDrawerSideAnimatedVelocityAnimationOptionsCompletion_Handle, (int)drawerSide, animated, velocity, (int)options, (IntPtr) block_ptr_Completion);
			block_ptr_Completion->CleanupBlock ();
			
		}
		
		[Export ("panGestureCallback:")]
		[CompilerGenerated]
		public static void PanGestureCallback (this MMDrawerController This, global::MonoTouch.UIKit.UIPanGestureRecognizer panGesture)
		{
			if (panGesture == null)
				throw new ArgumentNullException ("panGesture");
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, selPanGestureCallback_Handle, panGesture.Handle);
		}
		
		[Export ("prepareToPresentDrawer:animated:")]
		[CompilerGenerated]
		public static void PrepareToPresentDrawer (this MMDrawerController This, MMDrawerSide drawer, bool animated)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_int_bool (This.Handle, selPrepareToPresentDrawerAnimated_Handle, (int)drawer, animated);
		}
		
		[Export ("tapGestureCallback:")]
		[CompilerGenerated]
		public static void TapGestureCallback (this MMDrawerController This, global::MonoTouch.UIKit.UITapGestureRecognizer tapGesture)
		{
			if (tapGesture == null)
				throw new ArgumentNullException ("tapGesture");
			ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, selTapGestureCallback_Handle, tapGesture.Handle);
		}
		
		[Export ("willAnimateRotationToInterfaceOrientation:duration:")]
		[CompilerGenerated]
		public static void WillAnimateRotationToInterfaceOrientation (this MMDrawerController This, global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation, global::System.Double duration)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_int_Double (This.Handle, selWillAnimateRotationToInterfaceOrientationDuration_Handle, (int)toInterfaceOrientation, duration);
		}
		
		[Export ("willRotateToInterfaceOrientation:duration:")]
		[CompilerGenerated]
		public static void WillRotateToInterfaceOrientation (this MMDrawerController This, global::MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation, global::System.Double duration)
		{
			ApiDefinitions.Messaging.void_objc_msgSend_int_Double (This.Handle, selWillRotateToInterfaceOrientationDuration_Handle, (int)toInterfaceOrientation, duration);
		}
		
	} /* class Subclass_MMDrawerController */
}
