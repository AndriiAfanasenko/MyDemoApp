package md5a8be4a6364873456f106b5177ae5e322;


public class MainView
	extends mvvmcross.droid.support.v7.appcompat.MvxAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PerFIct.Droid.Views.MainView, PerFIct.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainView.class, __md_methods);
	}


	public MainView ()
	{
		super ();
		if (getClass () == MainView.class)
			mono.android.TypeManager.Activate ("PerFIct.Droid.Views.MainView, PerFIct.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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