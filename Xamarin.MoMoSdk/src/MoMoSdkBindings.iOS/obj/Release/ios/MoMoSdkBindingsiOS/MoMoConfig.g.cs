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
	[Register("MoMoConfig", true)]
	public unsafe partial class MoMoConfig : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MoMoConfig");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MoMoConfig () : base (NSObjectFlag.Empty)
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
		protected MoMoConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MoMoConfig (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAction:")]
		[CompilerGenerated]
		public static void SetAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAction:"), nsaction);
			NSString.ReleaseNative (nsaction);
			
		}
		
		[Export ("setAppBundleId:")]
		[CompilerGenerated]
		public static void SetAppBundleId (string bundleId)
		{
			if (bundleId == null)
				throw new ArgumentNullException ("bundleId");
			var nsbundleId = NSString.CreateNative (bundleId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setAppBundleId:"), nsbundleId);
			NSString.ReleaseNative (nsbundleId);
			
		}
		
		[Export ("setEnvironment:")]
		[CompilerGenerated]
		public static void SetEnvironment (bool isproduct)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEnvironment:"), isproduct);
		}
		
		[Export ("setMerchantcode:")]
		[CompilerGenerated]
		public static void SetMerchantcode (string merchantCode)
		{
			if (merchantCode == null)
				throw new ArgumentNullException ("merchantCode");
			var nsmerchantCode = NSString.CreateNative (merchantCode);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setMerchantcode:"), nsmerchantCode);
			NSString.ReleaseNative (nsmerchantCode);
			
		}
		
		[Export ("setMerchantname:")]
		[CompilerGenerated]
		public static void SetMerchantname (string merchantName)
		{
			if (merchantName == null)
				throw new ArgumentNullException ("merchantName");
			var nsmerchantName = NSString.CreateNative (merchantName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setMerchantname:"), nsmerchantName);
			NSString.ReleaseNative (nsmerchantName);
			
		}
		
		[Export ("setMerchantnameLabel:")]
		[CompilerGenerated]
		public static void SetMerchantnameLabel (string merchantnameLabel)
		{
			if (merchantnameLabel == null)
				throw new ArgumentNullException ("merchantnameLabel");
			var nsmerchantnameLabel = NSString.CreateNative (merchantnameLabel);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setMerchantnameLabel:"), nsmerchantnameLabel);
			NSString.ReleaseNative (nsmerchantnameLabel);
			
		}
		
		[Export ("setMoMoAppScheme:")]
		[CompilerGenerated]
		public static void SetMoMoAppScheme (string bundleId)
		{
			if (bundleId == null)
				throw new ArgumentNullException ("bundleId");
			var nsbundleId = NSString.CreateNative (bundleId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setMoMoAppScheme:"), nsbundleId);
			NSString.ReleaseNative (nsbundleId);
			
		}
		
		[Export ("setPublickey:")]
		[CompilerGenerated]
		public static void SetPublickey (string merchantpublickey)
		{
			if (merchantpublickey == null)
				throw new ArgumentNullException ("merchantpublickey");
			var nsmerchantpublickey = NSString.CreateNative (merchantpublickey);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPublickey:"), nsmerchantpublickey);
			NSString.ReleaseNative (nsmerchantpublickey);
			
		}
		
		[Export ("setSubmitUrl:")]
		[CompilerGenerated]
		public static void SetSubmitUrl (string submiturl)
		{
			if (submiturl == null)
				throw new ArgumentNullException ("submiturl");
			var nssubmiturl = NSString.CreateNative (submiturl);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setSubmitUrl:"), nssubmiturl);
			NSString.ReleaseNative (nssubmiturl);
			
		}
		
		[Export ("setUsernameLabel:")]
		[CompilerGenerated]
		public static void SetUsernameLabel (string usernameLabel)
		{
			if (usernameLabel == null)
				throw new ArgumentNullException ("usernameLabel");
			var nsusernameLabel = NSString.CreateNative (usernameLabel);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUsernameLabel:"), nsusernameLabel);
			NSString.ReleaseNative (nsusernameLabel);
			
		}
		
		[CompilerGenerated]
		public static string Action {
			[Export ("getAction")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getAction")));
			}
			
		}
		
		[CompilerGenerated]
		public static string AppBundleId {
			[Export ("getAppBundleId")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getAppBundleId")));
			}
			
		}
		
		[CompilerGenerated]
		public static string DeviceInfoString {
			[Export ("getDeviceInfoString")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getDeviceInfoString")));
			}
			
		}
		
		[CompilerGenerated]
		public static bool Environment {
			[Export ("getEnvironment")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("getEnvironment"));
			}
			
		}
		
		[CompilerGenerated]
		public static string IPAddress {
			[Export ("getIPAddress")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getIPAddress")));
			}
			
		}
		
		[CompilerGenerated]
		public static string Merchantcode {
			[Export ("getMerchantcode")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMerchantcode")));
			}
			
		}
		
		[CompilerGenerated]
		public static string Merchantname {
			[Export ("getMerchantname")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMerchantname")));
			}
			
		}
		
		[CompilerGenerated]
		public static string MerchantnameLabel {
			[Export ("getMerchantnameLabel")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMerchantnameLabel")));
			}
			
		}
		
		[CompilerGenerated]
		public static string MoMoAppScheme {
			[Export ("getMoMoAppScheme")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMoMoAppScheme")));
			}
			
		}
		
		[CompilerGenerated]
		public static string Publickey {
			[Export ("getPublickey")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getPublickey")));
			}
			
		}
		
		[CompilerGenerated]
		public static string SubmitUrl {
			[Export ("getSubmitUrl")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getSubmitUrl")));
			}
			
		}
		
		[CompilerGenerated]
		public static string UsernameLabel {
			[Export ("getUsernameLabel")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getUsernameLabel")));
			}
			
		}
		
	} /* class MoMoConfig */
}
