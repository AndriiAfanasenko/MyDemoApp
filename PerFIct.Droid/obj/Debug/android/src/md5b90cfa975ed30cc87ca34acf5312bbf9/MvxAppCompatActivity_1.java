package md5b90cfa975ed30cc87ca34acf5312bbf9;


public abstract class MvxAppCompatActivity_1
	extends mvvmcross.droid.support.v7.appcompat.MvxAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatActivity`1, MvvmCross.Droid.Support.V7.AppCompat, Version=5.6.3.0, Culture=neutral, PublicKeyToken=null", MvxAppCompatActivity_1.class, __md_methods);
	}


	public MvxAppCompatActivity_1 ()
	{
		super ();
		if (getClass () == MvxAppCompatActivity_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatActivity`1, MvvmCross.Droid.Support.V7.AppCompat, Version=5.6.3.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
