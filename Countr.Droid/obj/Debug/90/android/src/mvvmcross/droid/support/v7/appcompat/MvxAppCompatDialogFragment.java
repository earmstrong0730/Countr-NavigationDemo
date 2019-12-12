package mvvmcross.droid.support.v7.appcompat;


public abstract class MvxAppCompatDialogFragment
	extends md5c44e626e43e5b8d6d42d28410a243d52.MvxEventSourceAppCompatDialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatDialogFragment, MvvmCross.Droid.Support.V7.AppCompat", MvxAppCompatDialogFragment.class, __md_methods);
	}


	public MvxAppCompatDialogFragment ()
	{
		super ();
		if (getClass () == MvxAppCompatDialogFragment.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatDialogFragment, MvvmCross.Droid.Support.V7.AppCompat", "", this, new java.lang.Object[] {  });
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
