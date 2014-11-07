
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using Xamarin.Forms.Platform.Android;
using QuickTodo;
using Xamarin.Forms;
using System.Reflection;

namespace Forms2Native
{
	[Activity (Label = "MyThirdActivity",
		ConfigurationChanges = ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode | ConfigChanges.ScreenLayout)]
	public class MyThirdActivity : AndroidActivity
	{
		public static Page page = null;
		public static Xamarin.Forms.Platform.Android.AndroidActivity test;

		protected override void OnCreate (Bundle bundle)
		{
			test = this;
			/*RequestWindowFeature(WindowFeatures.ActionBar);
			RequestWindowFeature(WindowFeatures.ActionBarOverlay);*/

			base.OnCreate (bundle);

			page = new NavigationPage(new MyPage ());
			this.SetPage (page);
		}

		/* Uncomment this code to make this work 
		public override void OnBackPressed ()
		{
			var ev = typeof(AndroidActivity).GetField ("BackPressed", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null);
			var list = (Delegate[])ev.GetType ().GetMethod ("GetInvocationList").Invoke (ev, null);
			var test = (BackButtonPressedEventHandler)list.Last();
			AndroidActivity.BackPressed -= test;
			this.Finish ();
		}
		*/
	}
}

