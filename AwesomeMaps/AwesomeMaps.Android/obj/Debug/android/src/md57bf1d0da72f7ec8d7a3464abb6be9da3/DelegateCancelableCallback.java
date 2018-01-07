package md57bf1d0da72f7ec8d7a3464abb6be9da3;


public class DelegateCancelableCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.CancelableCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:()V:GetOnCancelHandler:Android.Gms.Maps.GoogleMap/ICancelableCallbackInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"n_onFinish:()V:GetOnFinishHandler:Android.Gms.Maps.GoogleMap/ICancelableCallbackInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.GoogleMaps.Android.Logics.DelegateCancelableCallback, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", DelegateCancelableCallback.class, __md_methods);
	}


	public DelegateCancelableCallback ()
	{
		super ();
		if (getClass () == DelegateCancelableCallback.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.GoogleMaps.Android.Logics.DelegateCancelableCallback, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCancel ()
	{
		n_onCancel ();
	}

	private native void n_onCancel ();


	public void onFinish ()
	{
		n_onFinish ();
	}

	private native void n_onFinish ();

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
