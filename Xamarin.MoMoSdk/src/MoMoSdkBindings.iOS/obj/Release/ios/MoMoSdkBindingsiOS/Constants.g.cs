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
	public unsafe static partial class Constants  {
		
		[CompilerGenerated]
		static NSString _CLIENT_IP_ADDRESS;
		[Field ("CLIENT_IP_ADDRESS",  "__Internal")]
		public static NSString CLIENT_IP_ADDRESS {
			get {
				if (_CLIENT_IP_ADDRESS == null)
					_CLIENT_IP_ADDRESS = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CLIENT_IP_ADDRESS");
				return _CLIENT_IP_ADDRESS;
			}
		}
		[CompilerGenerated]
		static NSString _CLIENT_MERCHANT_CODE;
		[Field ("CLIENT_MERCHANT_CODE",  "__Internal")]
		public static NSString CLIENT_MERCHANT_CODE {
			get {
				if (_CLIENT_MERCHANT_CODE == null)
					_CLIENT_MERCHANT_CODE = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CLIENT_MERCHANT_CODE");
				return _CLIENT_MERCHANT_CODE;
			}
		}
		[CompilerGenerated]
		static NSString _CLIENT_MERCHANT_NAME;
		[Field ("CLIENT_MERCHANT_NAME",  "__Internal")]
		public static NSString CLIENT_MERCHANT_NAME {
			get {
				if (_CLIENT_MERCHANT_NAME == null)
					_CLIENT_MERCHANT_NAME = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CLIENT_MERCHANT_NAME");
				return _CLIENT_MERCHANT_NAME;
			}
		}
		[CompilerGenerated]
		static NSString _CLIENT_MERCHANT_NAME_LABEL;
		[Field ("CLIENT_MERCHANT_NAME_LABEL",  "__Internal")]
		public static NSString CLIENT_MERCHANT_NAME_LABEL {
			get {
				if (_CLIENT_MERCHANT_NAME_LABEL == null)
					_CLIENT_MERCHANT_NAME_LABEL = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CLIENT_MERCHANT_NAME_LABEL");
				return _CLIENT_MERCHANT_NAME_LABEL;
			}
		}
		[CompilerGenerated]
		static NSString _CLIENT_PUBLIC_KEY;
		[Field ("CLIENT_PUBLIC_KEY",  "__Internal")]
		public static NSString CLIENT_PUBLIC_KEY {
			get {
				if (_CLIENT_PUBLIC_KEY == null)
					_CLIENT_PUBLIC_KEY = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CLIENT_PUBLIC_KEY");
				return _CLIENT_PUBLIC_KEY;
			}
		}
	} /* class Constants */
}
