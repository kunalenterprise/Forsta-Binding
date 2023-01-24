package mono.com.confirmit.mobilesdk.web;


public class WrappedWebViewClient_OnWebViewListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.confirmit.mobilesdk.web.WrappedWebViewClient.OnWebViewListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doUpdateVisitedHistory:(Landroid/webkit/WebView;Ljava/lang/String;Z)V:GetDoUpdateVisitedHistory_Landroid_webkit_WebView_Ljava_lang_String_ZHandler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta\n" +
			"n_onError:(Landroid/webkit/WebResourceRequest;Landroidx/webkit/WebResourceErrorCompat;)V:GetOnError_Landroid_webkit_WebResourceRequest_Landroidx_webkit_WebResourceErrorCompat_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta\n" +
			"n_onLoadResource:(Ljava/lang/String;)V:GetOnLoadResource_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta\n" +
			"n_onPageFinished:(Ljava/lang/String;)V:GetOnPageFinished_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta\n" +
			"n_onShouldOverrideUrlLoading:(Landroid/webkit/WebView;Ljava/lang/String;)Z:GetOnShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient/IOnWebViewListenerInvoker, Forsta\n" +
			"";
		mono.android.Runtime.register ("Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient+IOnWebViewListenerImplementor, Forsta", WrappedWebViewClient_OnWebViewListenerImplementor.class, __md_methods);
	}


	public WrappedWebViewClient_OnWebViewListenerImplementor ()
	{
		super ();
		if (getClass () == WrappedWebViewClient_OnWebViewListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Confirmit.Mobilesdk.Web.WrappedWebViewClient+IOnWebViewListenerImplementor, Forsta", "", this, new java.lang.Object[] {  });
		}
	}


	public void doUpdateVisitedHistory (android.webkit.WebView p0, java.lang.String p1, boolean p2)
	{
		n_doUpdateVisitedHistory (p0, p1, p2);
	}

	private native void n_doUpdateVisitedHistory (android.webkit.WebView p0, java.lang.String p1, boolean p2);


	public void onError (android.webkit.WebResourceRequest p0, androidx.webkit.WebResourceErrorCompat p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (android.webkit.WebResourceRequest p0, androidx.webkit.WebResourceErrorCompat p1);


	public void onLoadResource (java.lang.String p0)
	{
		n_onLoadResource (p0);
	}

	private native void n_onLoadResource (java.lang.String p0);


	public void onPageFinished (java.lang.String p0)
	{
		n_onPageFinished (p0);
	}

	private native void n_onPageFinished (java.lang.String p0);


	public boolean onShouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1)
	{
		return n_onShouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_onShouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
