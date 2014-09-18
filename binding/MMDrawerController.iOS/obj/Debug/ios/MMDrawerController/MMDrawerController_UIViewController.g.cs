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
	public unsafe static partial class MMDrawerController_UIViewController  {
		[CompilerGenerated]
		const string selMm_drawerController = "mm_drawerController";
		static readonly IntPtr selMm_drawerControllerHandle = Selector.GetHandle ("mm_drawerController");
		[CompilerGenerated]
		const string selMm_visibleDrawerFrame = "mm_visibleDrawerFrame";
		static readonly IntPtr selMm_visibleDrawerFrameHandle = Selector.GetHandle ("mm_visibleDrawerFrame");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIViewController");
		
		[CompilerGenerated]
		static object __mt_Mm_drawerController_var_static;
		[CompilerGenerated]
		public static MMDrawerController Mm_drawerController {
			[Export ("mm_drawerController", ArgumentSemantic.Retain)]
			get {
				MMDrawerController ret;
				ret =  Runtime.GetNSObject<MMDrawerController> (ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, selMm_drawerControllerHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Mm_drawerController_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static global::System.Drawing.RectangleF Mm_visibleDrawerFrame {
			[Export ("mm_visibleDrawerFrame", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::System.Drawing.RectangleF ret;
				ApiDefinitions.Messaging.RectangleF_objc_msgSend_stret (out ret, class_ptr, selMm_visibleDrawerFrameHandle);
				return ret;
			}
			
		}
		
	} /* class MMDrawerController_UIViewController */
}
