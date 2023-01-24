package mono.androidx.webkit;


public class WebViewCompat_WebMessageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.webkit.WebViewCompat.WebMessageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPostMessage:(Landroid/webkit/WebView;Landroidx/webkit/WebMessageCompat;Landroid/net/Uri;ZLandroidx/webkit/JavaScriptReplyProxy;)V:GetOnPostMessage_Landroid_webkit_WebView_Landroidx_webkit_WebMessageCompat_Landroid_net_Uri_ZLandroidx_webkit_JavaScriptReplyProxy_Handler:AndroidX.WebKit.WebViewCompat/IWebMessageListenerInvoker, Xamarin.AndroidX.WebKit\n" +
			"";
		mono.android.Runtime.register ("AndroidX.WebKit.WebViewCompat+IWebMessageListenerImplementor, Xamarin.AndroidX.WebKit", WebViewCompat_WebMessageListenerImplementor.class, __md_methods);
	}


	public WebViewCompat_WebMessageListenerImplementor ()
	{
		super ();
		if (getClass () == WebViewCompat_WebMessageListenerImplementor.class) {
			mono.android.TypeManager.Activate ("AndroidX.WebKit.WebViewCompat+IWebMessageListenerImplementor, Xamarin.AndroidX.WebKit", "", this, new java.lang.Object[] {  });
		}
	}


	public void onPostMessage (android.webkit.WebView p0, androidx.webkit.WebMessageCompat p1, android.net.Uri p2, boolean p3, androidx.webkit.JavaScriptReplyProxy p4)
	{
		n_onPostMessage (p0, p1, p2, p3, p4);
	}

	private native void n_onPostMessage (android.webkit.WebView p0, androidx.webkit.WebMessageCompat p1, android.net.Uri p2, boolean p3, androidx.webkit.JavaScriptReplyProxy p4);

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
