using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Xamarin.Forms;

namespace Forms2Native
{
	/// <summary>
	/// Android app starts with Xamarin.Forms, then opens a natively rendered Page
	/// </summary>
	[Activity (Label = "Forms2Native", MainLauncher = true)]
	public class Activity1 : Xamarin.Forms.Platform.Android.AndroidActivity
	{
		public static Page page;
		public static Xamarin.Forms.Platform.Android.AndroidActivity test;

		protected override void OnCreate (Bundle bundle)
		{
			test = this;
			Console.WriteLine ("created " + DateTime.Now);
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			// Starts with the main Xamarin.Forms screen
			page = App.GetMainPage ();
			SetPage (page);

			MyFirstPage.test = () => {
				//var activity = this.Context as Activity;
				var thirdActivity = new Intent (this, typeof(MyThirdActivity));
				StartActivity (thirdActivity);
			};
		}

		protected override void OnPostResume ()
		{
			base.OnPostResume ();

			//SetPage (page);
		}

		public override void OnBackPressed ()
		{
			Console.WriteLine ("back pressed " + DateTime.Now);
			base.OnBackPressed ();
		}
	}
}


