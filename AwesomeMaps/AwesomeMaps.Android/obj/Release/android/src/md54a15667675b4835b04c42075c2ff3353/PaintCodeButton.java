package md54a15667675b4835b04c42075c2ff3353;


public class PaintCodeButton
	extends android.widget.Button
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("AwesomeMaps.Droid.PaintCodeButton, AwesomeMaps.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PaintCodeButton.class, __md_methods);
	}


	public PaintCodeButton (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PaintCodeButton.class)
			mono.android.TypeManager.Activate ("AwesomeMaps.Droid.PaintCodeButton, AwesomeMaps.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public PaintCodeButton (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PaintCodeButton.class)
			mono.android.TypeManager.Activate ("AwesomeMaps.Droid.PaintCodeButton, AwesomeMaps.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public PaintCodeButton (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PaintCodeButton.class)
			mono.android.TypeManager.Activate ("AwesomeMaps.Droid.PaintCodeButton, AwesomeMaps.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);

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
