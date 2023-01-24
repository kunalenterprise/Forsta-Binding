package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("ForstaDemo.ForstaApplication, ForstaDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64feca9bdbf20c442c.ForstaApplication.class, crc64feca9bdbf20c442c.ForstaApplication.__md_methods);
		
	}
}
