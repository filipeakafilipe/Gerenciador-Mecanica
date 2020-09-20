package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("Mecanica.App.Droid.MainApplication, Mecanica.App.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc641aa6e59966773960.MainApplication.class, crc641aa6e59966773960.MainApplication.__md_methods);
		
	}
}
