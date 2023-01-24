package mono.com.confirmit.mobilesdk.ui;


public class SurveyFrameLifecycleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSurveyErrored:(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;Ljava/lang/Exception;)V:GetOnSurveyErrored_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta\n" +
			"n_onSurveyFinished:(Lcom/confirmit/mobilesdk/ui/SurveyPage;Ljava/util/Map;)V:GetOnSurveyFinished_Lcom_confirmit_mobilesdk_ui_SurveyPage_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta\n" +
			"n_onSurveyPageReady:(Lcom/confirmit/mobilesdk/ui/SurveyPage;)V:GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_ui_SurveyPage_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta\n" +
			"n_onSurveyQuit:(Ljava/util/Map;)V:GetOnSurveyQuit_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerInvoker, Forsta\n" +
			"";
		mono.android.Runtime.register ("Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor, Forsta", SurveyFrameLifecycleListenerImplementor.class, __md_methods);
	}


	public SurveyFrameLifecycleListenerImplementor ()
	{
		super ();
		if (getClass () == SurveyFrameLifecycleListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor, Forsta", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSurveyErrored (com.confirmit.mobilesdk.ui.SurveyPage p0, java.util.Map p1, java.lang.Exception p2)
	{
		n_onSurveyErrored (p0, p1, p2);
	}

	private native void n_onSurveyErrored (com.confirmit.mobilesdk.ui.SurveyPage p0, java.util.Map p1, java.lang.Exception p2);


	public void onSurveyFinished (com.confirmit.mobilesdk.ui.SurveyPage p0, java.util.Map p1)
	{
		n_onSurveyFinished (p0, p1);
	}

	private native void n_onSurveyFinished (com.confirmit.mobilesdk.ui.SurveyPage p0, java.util.Map p1);


	public void onSurveyPageReady (com.confirmit.mobilesdk.ui.SurveyPage p0)
	{
		n_onSurveyPageReady (p0);
	}

	private native void n_onSurveyPageReady (com.confirmit.mobilesdk.ui.SurveyPage p0);


	public void onSurveyQuit (java.util.Map p0)
	{
		n_onSurveyQuit (p0);
	}

	private native void n_onSurveyQuit (java.util.Map p0);

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
