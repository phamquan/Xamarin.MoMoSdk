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
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace MoMoSdkBindings.iOS {
	[Register("MoMoPayment", true)]
	public unsafe partial class MoMoPayment : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MoMoPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MoMoPayment () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MoMoPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MoMoPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addMoMoPayCustomButton:forControlEvents:toView:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIButton AddMoMoPayCustomButton (global::UIKit.UIButton button, global::UIKit.UIControlEvent controlEvents, global::UIKit.UIView parrentView)
		{
			if (button == null)
				throw new ArgumentNullException ("button");
			if (parrentView == null)
				throw new ArgumentNullException ("parrentView");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("addMoMoPayCustomButton:forControlEvents:toView:"), button.Handle, (UInt64)controlEvents, parrentView.Handle));
				} else {
					return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("addMoMoPayCustomButton:forControlEvents:toView:"), button.Handle, (UInt32)controlEvents, parrentView.Handle));
				}
			} else {
				if (IntPtr.Size == 8) {
					return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr (this.SuperHandle, Selector.GetHandle ("addMoMoPayCustomButton:forControlEvents:toView:"), button.Handle, (UInt64)controlEvents, parrentView.Handle));
				} else {
					return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("addMoMoPayCustomButton:forControlEvents:toView:"), button.Handle, (UInt32)controlEvents, parrentView.Handle));
				}
			}
		}
		
		[Export ("addMoMoPayDefaultButtonToView:")]
		[CompilerGenerated]
		public virtual void AddMoMoPayDefaultButtonToView (global::UIKit.UIView parrentView)
		{
			if (parrentView == null)
				throw new ArgumentNullException ("parrentView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addMoMoPayDefaultButtonToView:"), parrentView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addMoMoPayDefaultButtonToView:"), parrentView.Handle);
			}
		}
		
		[Export ("createPaymentInformation:")]
		[CompilerGenerated]
		public virtual void CreatePaymentInformation (NSMutableDictionary info)
		{
			if (info == null)
				throw new ArgumentNullException ("info");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createPaymentInformation:"), info.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createPaymentInformation:"), info.Handle);
			}
		}
		
		[Export ("handleOpenUrl:")]
		[CompilerGenerated]
		public virtual void HandleOpenUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handleOpenUrl:"), url.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handleOpenUrl:"), url.Handle);
			}
		}
		
		[Export ("initPaymentInformation:momoAppScheme:environment:")]
		[CompilerGenerated]
		public virtual void InitPaymentInformation (NSMutableDictionary info, string bundleId, MomoEnvirontment type_environment)
		{
			if (info == null)
				throw new ArgumentNullException ("info");
			if (bundleId == null)
				throw new ArgumentNullException ("bundleId");
			var nsbundleId = NSString.CreateNative (bundleId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("initPaymentInformation:momoAppScheme:environment:"), info.Handle, nsbundleId, (UInt32)type_environment);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("initPaymentInformation:momoAppScheme:environment:"), info.Handle, nsbundleId, (UInt32)type_environment);
			}
			NSString.ReleaseNative (nsbundleId);
			
		}
		
		[Export ("initializingAppBundleId:merchantId:merchantName:merchantNameTitle:billTitle:")]
		[CompilerGenerated]
		public virtual void InitializingAppBundleId (string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle)
		{
			if (bundleid == null)
				throw new ArgumentNullException ("bundleid");
			if (merchantId == null)
				throw new ArgumentNullException ("merchantId");
			if (merchantname == null)
				throw new ArgumentNullException ("merchantname");
			if (merchantNameTitle == null)
				throw new ArgumentNullException ("merchantNameTitle");
			if (billTitle == null)
				throw new ArgumentNullException ("billTitle");
			var nsbundleid = NSString.CreateNative (bundleid);
			var nsmerchantId = NSString.CreateNative (merchantId);
			var nsmerchantname = NSString.CreateNative (merchantname);
			var nsmerchantNameTitle = NSString.CreateNative (merchantNameTitle);
			var nsbillTitle = NSString.CreateNative (billTitle);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initializingAppBundleId:merchantId:merchantName:merchantNameTitle:billTitle:"), nsbundleid, nsmerchantId, nsmerchantname, nsmerchantNameTitle, nsbillTitle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initializingAppBundleId:merchantId:merchantName:merchantNameTitle:billTitle:"), nsbundleid, nsmerchantId, nsmerchantname, nsmerchantNameTitle, nsbillTitle);
			}
			NSString.ReleaseNative (nsbundleid);
			NSString.ReleaseNative (nsmerchantId);
			NSString.ReleaseNative (nsmerchantname);
			NSString.ReleaseNative (nsmerchantNameTitle);
			NSString.ReleaseNative (nsbillTitle);
			
		}
		
		[Export ("requestToken")]
		[CompilerGenerated]
		public virtual void RequestToken ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestToken"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestToken"));
			}
		}
		
		[Export ("requestWebpaymentData:requestType:")]
		[CompilerGenerated]
		public virtual void RequestWebpaymentData (NSMutableDictionary dataPost, string requesttype)
		{
			if (dataPost == null)
				throw new ArgumentNullException ("dataPost");
			if (requesttype == null)
				throw new ArgumentNullException ("requesttype");
			var nsrequesttype = NSString.CreateNative (requesttype);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestWebpaymentData:requestType:"), dataPost.Handle, nsrequesttype);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("requestWebpaymentData:requestType:"), dataPost.Handle, nsrequesttype);
			}
			NSString.ReleaseNative (nsrequesttype);
			
		}
		
		[Export ("setAction:")]
		[CompilerGenerated]
		public virtual void SetAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAction:"), nsaction);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAction:"), nsaction);
			}
			NSString.ReleaseNative (nsaction);
			
		}
		
		[Export ("setEnvironment:")]
		[CompilerGenerated]
		public virtual void SetEnvironment (MomoEnvirontment type_environtment)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setEnvironment:"), (UInt32)type_environtment);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setEnvironment:"), (UInt32)type_environtment);
			}
		}
		
		[Export ("setMoMoAppScheme:")]
		[CompilerGenerated]
		public virtual void SetMoMoAppScheme (string bundleId)
		{
			if (bundleId == null)
				throw new ArgumentNullException ("bundleId");
			var nsbundleId = NSString.CreateNative (bundleId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMoMoAppScheme:"), nsbundleId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMoMoAppScheme:"), nsbundleId);
			}
			NSString.ReleaseNative (nsbundleId);
			
		}
		
		[Export ("setSubmitURL:")]
		[CompilerGenerated]
		public virtual void SetSubmitURL (string submitUrl)
		{
			if (submitUrl == null)
				throw new ArgumentNullException ("submitUrl");
			var nssubmitUrl = NSString.CreateNative (submitUrl);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubmitURL:"), nssubmitUrl);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubmitURL:"), nssubmitUrl);
			}
			NSString.ReleaseNative (nssubmitUrl);
			
		}
		
		[Export ("updateAmount:")]
		[CompilerGenerated]
		public virtual void UpdateAmount (long amt)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("updateAmount:"), amt);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("updateAmount:"), amt);
			}
		}
		
		[CompilerGenerated]
		public virtual string Action {
			[Export ("getAction")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAction")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAction")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceInfoString {
			[Export ("getDeviceInfoString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceInfoString")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceInfoString")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Environment {
			[Export ("getEnvironment")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getEnvironment"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEnvironment"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSMutableDictionary PaymentInfo {
			[Export ("getPaymentInfo")]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getPaymentInfo")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPaymentInfo")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static MoMoPayment ShareInstant {
			[Export ("shareInstant")]
			get {
				MoMoPayment ret;
				ret =  Runtime.GetNSObject<MoMoPayment> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("shareInstant")));
				return ret;
			}
			
		}
		
	} /* class MoMoPayment */
}
