package md59e1546199385abe7b23a89990a0f94aa;


public class MapRenderer
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.ViewRenderer
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnCameraChangeListener,
		com.google.android.gms.maps.GoogleMap.OnMapClickListener,
		com.google.android.gms.maps.GoogleMap.OnMapLongClickListener,
		com.google.android.gms.maps.GoogleMap.OnMyLocationButtonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_onCameraChange:(Lcom/google/android/gms/maps/model/CameraPosition;)V:GetOnCameraChange_Lcom_google_android_gms_maps_model_CameraPosition_Handler:Android.Gms.Maps.GoogleMap/IOnCameraChangeListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"n_onMapClick:(Lcom/google/android/gms/maps/model/LatLng;)V:GetOnMapClick_Lcom_google_android_gms_maps_model_LatLng_Handler:Android.Gms.Maps.GoogleMap/IOnMapClickListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"n_onMapLongClick:(Lcom/google/android/gms/maps/model/LatLng;)V:GetOnMapLongClick_Lcom_google_android_gms_maps_model_LatLng_Handler:Android.Gms.Maps.GoogleMap/IOnMapLongClickListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"n_onMyLocationButtonClick:()Z:GetOnMyLocationButtonClickHandler:Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.GoogleMaps.Android.MapRenderer, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", MapRenderer.class, __md_methods);
	}


	public MapRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MapRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.GoogleMaps.Android.MapRenderer, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MapRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MapRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.GoogleMaps.Android.MapRenderer, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public MapRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MapRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.GoogleMaps.Android.MapRenderer, Xamarin.Forms.GoogleMaps.Android, Version=2.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void onCameraChange (com.google.android.gms.maps.model.CameraPosition p0)
	{
		n_onCameraChange (p0);
	}

	private native void n_onCameraChange (com.google.android.gms.maps.model.CameraPosition p0);


	public void onMapClick (com.google.android.gms.maps.model.LatLng p0)
	{
		n_onMapClick (p0);
	}

	private native void n_onMapClick (com.google.android.gms.maps.model.LatLng p0);


	public void onMapLongClick (com.google.android.gms.maps.model.LatLng p0)
	{
		n_onMapLongClick (p0);
	}

	private native void n_onMapLongClick (com.google.android.gms.maps.model.LatLng p0);


	public boolean onMyLocationButtonClick ()
	{
		return n_onMyLocationButtonClick ();
	}

	private native boolean n_onMyLocationButtonClick ();

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
