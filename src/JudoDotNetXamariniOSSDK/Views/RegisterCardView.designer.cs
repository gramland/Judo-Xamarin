// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace JudoDotNetXamariniOSSDK
{
	[Register ("RegisterCardView")]
	partial class RegisterCardView
	{
		[Outlet]
		UIKit.UIView EncapsulatingView { get; set; }

		[Outlet]
		UIKit.UITableView TableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (EncapsulatingView != null) {
				EncapsulatingView.Dispose ();
				EncapsulatingView = null;
			}

			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}
		}
	}
}
