package mono.org.mozilla.javascript;


public class ContextFactory_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.mozilla.javascript.ContextFactory.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_contextCreated:(Lorg/mozilla/javascript/Context;)V:GetContextCreated_Lorg_mozilla_javascript_Context_Handler:Org.Mozilla.Javascript.ContextFactory/IListenerInvoker, RhinoBinding\n" +
			"n_contextReleased:(Lorg/mozilla/javascript/Context;)V:GetContextReleased_Lorg_mozilla_javascript_Context_Handler:Org.Mozilla.Javascript.ContextFactory/IListenerInvoker, RhinoBinding\n" +
			"";
		mono.android.Runtime.register ("Org.Mozilla.Javascript.ContextFactory+IListenerImplementor, RhinoBinding", ContextFactory_ListenerImplementor.class, __md_methods);
	}


	public ContextFactory_ListenerImplementor ()
	{
		super ();
		if (getClass () == ContextFactory_ListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Org.Mozilla.Javascript.ContextFactory+IListenerImplementor, RhinoBinding", "", this, new java.lang.Object[] {  });
		}
	}


	public void contextCreated (org.mozilla.javascript.Context p0)
	{
		n_contextCreated (p0);
	}

	private native void n_contextCreated (org.mozilla.javascript.Context p0);


	public void contextReleased (org.mozilla.javascript.Context p0)
	{
		n_contextReleased (p0);
	}

	private native void n_contextReleased (org.mozilla.javascript.Context p0);

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
