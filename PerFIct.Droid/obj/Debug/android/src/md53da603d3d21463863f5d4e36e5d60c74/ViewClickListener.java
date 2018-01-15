package md53da603d3d21463863f5d4e36e5d60c74;


public class ViewClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("PerFIct.Droid.Views.FragmentsMain.ViewClickListener, PerFIct.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewClickListener.class, __md_methods);
	}


	public ViewClickListener ()
	{
		super ();
		if (getClass () == ViewClickListener.class)
			mono.android.TypeManager.Activate ("PerFIct.Droid.Views.FragmentsMain.ViewClickListener, PerFIct.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ViewClickListener (android.content.Context p0, android.support.design.widget.TextInputEditText p1)
	{
		super ();
		if (getClass () == ViewClickListener.class)
			mono.android.TypeManager.Activate ("PerFIct.Droid.Views.FragmentsMain.ViewClickListener, PerFIct.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Support.Design.Widget.TextInputEditText, Xamarin.Android.Support.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

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
