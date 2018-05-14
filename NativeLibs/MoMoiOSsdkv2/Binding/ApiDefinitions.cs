using Foundation;
using UIKit;

// @interface MoMoPayment : NSObject
[BaseType (typeof(NSObject))]
interface MoMoPayment
{
	// +(MoMoPayment *)shareInstant;
	[Static]
	[Export ("shareInstant")]
	[Verify (MethodToProperty)]
	MoMoPayment ShareInstant { get; }

	// -(void)initializingAppBundleId:(NSString *)bundleid merchantId:(NSString *)merchantId merchantName:(NSString *)merchantname merchantNameTitle:(NSString *)merchantNameTitle billTitle:(NSString *)billTitle;
	[Export ("initializingAppBundleId:merchantId:merchantName:merchantNameTitle:billTitle:")]
	void InitializingAppBundleId (string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle);

	// -(void)requestToken;
	[Export ("requestToken")]
	void RequestToken ();

	// -(void)handleOpenUrl:(NSURL *)url;
	[Export ("handleOpenUrl:")]
	void HandleOpenUrl (NSUrl url);

	// -(void)createPaymentInformation:(NSMutableDictionary *)info;
	[Export ("createPaymentInformation:")]
	void CreatePaymentInformation (NSMutableDictionary info);

	// -(void)addMoMoPayDefaultButtonToView:(UIView *)parrentView;
	[Export ("addMoMoPayDefaultButtonToView:")]
	void AddMoMoPayDefaultButtonToView (UIView parrentView);

	// -(UIButton *)addMoMoPayCustomButton:(UIButton *)button forControlEvents:(UIControlEvents)controlEvents toView:(UIView *)parrentView;
	[Export ("addMoMoPayCustomButton:forControlEvents:toView:")]
	UIButton AddMoMoPayCustomButton (UIButton button, UIControlEvents controlEvents, UIView parrentView);

	// -(NSString *)getAction;
	[Export ("getAction")]
	[Verify (MethodToProperty)]
	string Action { get; }

	// -(void)setAction:(NSString *)action;
	[Export ("setAction:")]
	void SetAction (string action);

	// -(void)updateAmount:(long long)amt;
	[Export ("updateAmount:")]
	void UpdateAmount (long amt);

	// -(void)setSubmitURL:(NSString *)submitUrl;
	[Export ("setSubmitURL:")]
	void SetSubmitURL (string submitUrl);

	// -(NSMutableDictionary *)getPaymentInfo;
	[Export ("getPaymentInfo")]
	[Verify (MethodToProperty)]
	NSMutableDictionary PaymentInfo { get; }

	// -(void)requestWebpaymentData:(NSMutableDictionary *)dataPost requestType:(NSString *)requesttype;
	[Export ("requestWebpaymentData:requestType:")]
	void RequestWebpaymentData (NSMutableDictionary dataPost, string requesttype);

	// -(NSString *)getDeviceInfoString;
	[Export ("getDeviceInfoString")]
	[Verify (MethodToProperty)]
	string DeviceInfoString { get; }

	// -(void)setMoMoAppScheme:(NSString *)bundleId;
	[Export ("setMoMoAppScheme:")]
	void SetMoMoAppScheme (string bundleId);

	// -(void)initPaymentInformation:(NSMutableDictionary *)info momoAppScheme:(NSString *)bundleId environment:(MOMO_ENVIRONTMENT)type_environment;
	[Export ("initPaymentInformation:momoAppScheme:environment:")]
	void InitPaymentInformation (NSMutableDictionary info, string bundleId, MomoEnvirontment type_environment);

	// -(void)setEnvironment:(MOMO_ENVIRONTMENT)type_environtment;
	[Export ("setEnvironment:")]
	void SetEnvironment (MomoEnvirontment type_environtment);

	// -(BOOL)getEnvironment;
	[Export ("getEnvironment")]
	[Verify (MethodToProperty)]
	bool Environment { get; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString * CLIENT_MERCHANT_CODE;
	[Field ("CLIENT_MERCHANT_CODE", "__Internal")]
	NSString CLIENT_MERCHANT_CODE { get; }

	// extern NSString * CLIENT_MERCHANT_NAME;
	[Field ("CLIENT_MERCHANT_NAME", "__Internal")]
	NSString CLIENT_MERCHANT_NAME { get; }

	// extern NSString * CLIENT_MERCHANT_NAME_LABEL;
	[Field ("CLIENT_MERCHANT_NAME_LABEL", "__Internal")]
	NSString CLIENT_MERCHANT_NAME_LABEL { get; }

	// extern NSString * CLIENT_IP_ADDRESS;
	[Field ("CLIENT_IP_ADDRESS", "__Internal")]
	NSString CLIENT_IP_ADDRESS { get; }

	// extern NSString * CLIENT_PUBLIC_KEY;
	[Field ("CLIENT_PUBLIC_KEY", "__Internal")]
	NSString CLIENT_PUBLIC_KEY { get; }
}

// @interface MoMoConfig : NSObject
[BaseType (typeof(NSObject))]
interface MoMoConfig
{
	// +(void)setAppBundleId:(NSString *)bundleId;
	[Static]
	[Export ("setAppBundleId:")]
	void SetAppBundleId (string bundleId);

	// +(void)setMerchantcode:(NSString *)merchantCode;
	[Static]
	[Export ("setMerchantcode:")]
	void SetMerchantcode (string merchantCode);

	// +(void)setMerchantname:(NSString *)merchantName;
	[Static]
	[Export ("setMerchantname:")]
	void SetMerchantname (string merchantName);

	// +(void)setMerchantnameLabel:(NSString *)merchantnameLabel;
	[Static]
	[Export ("setMerchantnameLabel:")]
	void SetMerchantnameLabel (string merchantnameLabel);

	// +(void)setPublickey:(NSString *)merchantpublickey;
	[Static]
	[Export ("setPublickey:")]
	void SetPublickey (string merchantpublickey);

	// +(NSString *)getAppBundleId;
	[Static]
	[Export ("getAppBundleId")]
	[Verify (MethodToProperty)]
	string AppBundleId { get; }

	// +(NSString *)getPublickey;
	[Static]
	[Export ("getPublickey")]
	[Verify (MethodToProperty)]
	string Publickey { get; }

	// +(NSString *)getMerchantnameLabel;
	[Static]
	[Export ("getMerchantnameLabel")]
	[Verify (MethodToProperty)]
	string MerchantnameLabel { get; }

	// +(NSString *)getMerchantname;
	[Static]
	[Export ("getMerchantname")]
	[Verify (MethodToProperty)]
	string Merchantname { get; }

	// +(NSString *)getMerchantcode;
	[Static]
	[Export ("getMerchantcode")]
	[Verify (MethodToProperty)]
	string Merchantcode { get; }

	// +(NSString *)getIPAddress;
	[Static]
	[Export ("getIPAddress")]
	[Verify (MethodToProperty)]
	string IPAddress { get; }

	// +(NSString *)getDeviceInfoString;
	[Static]
	[Export ("getDeviceInfoString")]
	[Verify (MethodToProperty)]
	string DeviceInfoString { get; }

	// +(NSString *)getAction;
	[Static]
	[Export ("getAction")]
	[Verify (MethodToProperty)]
	string Action { get; }

	// +(void)setAction:(NSString *)action;
	[Static]
	[Export ("setAction:")]
	void SetAction (string action);

	// +(void)setUsernameLabel:(NSString *)usernameLabel;
	[Static]
	[Export ("setUsernameLabel:")]
	void SetUsernameLabel (string usernameLabel);

	// +(NSString *)getUsernameLabel;
	[Static]
	[Export ("getUsernameLabel")]
	[Verify (MethodToProperty)]
	string UsernameLabel { get; }

	// +(void)setSubmitUrl:(NSString *)submiturl;
	[Static]
	[Export ("setSubmitUrl:")]
	void SetSubmitUrl (string submiturl);

	// +(NSString *)getSubmitUrl;
	[Static]
	[Export ("getSubmitUrl")]
	[Verify (MethodToProperty)]
	string SubmitUrl { get; }

	// +(void)setMoMoAppScheme:(NSString *)bundleId;
	[Static]
	[Export ("setMoMoAppScheme:")]
	void SetMoMoAppScheme (string bundleId);

	// +(NSString *)getMoMoAppScheme;
	[Static]
	[Export ("getMoMoAppScheme")]
	[Verify (MethodToProperty)]
	string MoMoAppScheme { get; }

	// +(void)setEnvironment:(BOOL)isproduct;
	[Static]
	[Export ("setEnvironment:")]
	void SetEnvironment (bool isproduct);

	// +(BOOL)getEnvironment;
	[Static]
	[Export ("getEnvironment")]
	[Verify (MethodToProperty)]
	bool Environment { get; }
}

// @interface MoMoDialogs : UIViewController <UIWebViewDelegate>
[BaseType (typeof(UIViewController))]
interface MoMoDialogs : IUIWebViewDelegate
{
}
