package mono.com.confirmit.mobilesdk.surveyengine;


public class EngineLifeCycleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.confirmit.mobilesdk.surveyengine.EngineLifeCycleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSurveyErrored:(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;Ljava/lang/Exception;)V:GetOnSurveyErrored_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Ljava_lang_Exception_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta\n" +
			"n_onSurveyFinished:(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;)V:GetOnSurveyFinished_Lcom_confirmit_mobilesdk_surveyengine_packages_question_m_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta\n" +
			"n_onSurveyPageReady:(Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V:GetOnSurveyPageReady_Lcom_confirmit_mobilesdk_surveyengine_packages_question_k_Ljava_util_List_Ljava_util_Map_Lcom_confirmit_mobilesdk_surveyengine_o_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta\n" +
			"n_onSurveyQuit:(Ljava/util/Map;)V:GetOnSurveyQuit_Ljava_util_Map_Handler:Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerInvoker, Forsta\n" +
			"";
		mono.android.Runtime.register ("Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerImplementor, Forsta", EngineLifeCycleListenerImplementor.class, __md_methods);
	}


	public EngineLifeCycleListenerImplementor ()
	{
		super ();
		if (getClass () == EngineLifeCycleListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListenerImplementor, Forsta", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSurveyErrored (com.confirmit.mobilesdk.surveyengine.packages.question.m p0, java.util.Map p1, java.lang.Exception p2)
	{
		n_onSurveyErrored (p0, p1, p2);
	}

	private native void n_onSurveyErrored (com.confirmit.mobilesdk.surveyengine.packages.question.m p0, java.util.Map p1, java.lang.Exception p2);


	public void onSurveyFinished (com.confirmit.mobilesdk.surveyengine.packages.question.m p0, java.util.Map p1)
	{
		n_onSurveyFinished (p0, p1);
	}

	private native void n_onSurveyFinished (com.confirmit.mobilesdk.surveyengine.packages.question.m p0, java.util.Map p1);


	public void onSurveyPageReady (com.confirmit.mobilesdk.surveyengine.packages.question.k p0, java.util.List p1, java.util.Map p2, com.confirmit.mobilesdk.surveyengine.o p3, java.util.Map p4)
	{
		n_onSurveyPageReady (p0, p1, p2, p3, p4);
	}

	private native void n_onSurveyPageReady (com.confirmit.mobilesdk.surveyengine.packages.question.k p0, java.util.List p1, java.util.Map p2, com.confirmit.mobilesdk.surveyengine.o p3, java.util.Map p4);


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
