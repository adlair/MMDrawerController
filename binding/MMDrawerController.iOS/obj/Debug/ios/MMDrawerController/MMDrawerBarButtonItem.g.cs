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
	[Register("MMDrawerBarButtonItem", true)]
	public unsafe partial class MMDrawerBarButtonItem : global::MonoTouch.UIKit.UIBarButtonItem {
		[CompilerGenerated]
		const string selInitWithTargetAction_ = "initWithTarget:action:";
		static readonly IntPtr selInitWithTargetAction_Handle = Selector.GetHandle ("initWithTarget:action:");
		[CompilerGenerated]
		const string selMenuButtonColorForState_ = "menuButtonColorForState:";
		static readonly IntPtr selMenuButtonColorForState_Handle = Selector.GetHandle ("menuButtonColorForState:");
		[CompilerGenerated]
		const string selSetMenuButtonColorForState_ = "setMenuButtonColor:forState:";
		static readonly IntPtr selSetMenuButtonColorForState_Handle = Selector.GetHandle ("setMenuButtonColor:forState:");
		[CompilerGenerated]
		const string selSetShadowColorForState_ = "setShadowColor:forState:";
		static readonly IntPtr selSetShadowColorForState_Handle = Selector.GetHandle ("setShadowColor:forState:");
		[CompilerGenerated]
		const string selShadowColorForState_ = "shadowColorForState:";
		static readonly IntPtr selShadowColorForState_Handle = Selector.GetHandle ("shadowColorForState:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MMDrawerBarButtonItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MMDrawerBarButtonItem () : base (NSObjectFlag.Empty)
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
		public MMDrawerBarButtonItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public MMDrawerBarButtonItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMDrawerBarButtonItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithTarget:action:")]
		[CompilerGenerated]
		public MMDrawerBarButtonItem (NSObject target, Selector action)
			: base (NSObjectFlag.Empty)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (action == null)
				throw new ArgumentNullException ("action");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithTargetAction_Handle, target.Handle, action.Handle), "initWithTarget:action:");
			} else {
				InitializeHandle (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithTargetAction_Handle, target.Handle, action.Handle), "initWithTarget:action:");
			}
		}
		
		[Export ("menuButtonColorForState:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor MenuButtonColorForState (global::MonoTouch.UIKit.UIControlState state)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selMenuButtonColorForState_Handle, (UInt32)state));
			} else {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selMenuButtonColorForState_Handle, (UInt32)state));
			}
		}
		
		[Export ("setMenuButtonColor:forState:")]
		[CompilerGenerated]
		public virtual void SetMenuButtonColor (global::MonoTouch.UIKit.UIColor color, global::MonoTouch.UIKit.UIControlState state)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selSetMenuButtonColorForState_Handle, color.Handle, (UInt32)state);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selSetMenuButtonColorForState_Handle, color.Handle, (UInt32)state);
			}
		}
		
		[Export ("setShadowColor:forState:")]
		[CompilerGenerated]
		public virtual void SetShadowColor (global::MonoTouch.UIKit.UIColor color, global::MonoTouch.UIKit.UIControlState state)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			if (IsDirectBinding) {
				ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, selSetShadowColorForState_Handle, color.Handle, (UInt32)state);
			} else {
				ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selSetShadowColorForState_Handle, color.Handle, (UInt32)state);
			}
		}
		
		[Export ("shadowColorForState:")]
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor ShadowColorForState (global::MonoTouch.UIKit.UIControlState state)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selShadowColorForState_Handle, (UInt32)state));
			} else {
				return  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selShadowColorForState_Handle, (UInt32)state));
			}
		}
		
	} /* class MMDrawerBarButtonItem */
}
