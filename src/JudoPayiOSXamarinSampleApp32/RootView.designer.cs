// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
#if__UNIFIED__
using Foundation;
using UIKit;
using CoreFoundation;
using CoreGraphics;
// Mappings Unified CoreGraphic classes to MonoTouch classes
using RectangleF = global::CoreGraphics.CGRect;
using SizeF = global::CoreGraphics.CGSize;
using PointF = global::CoreGraphics.CGPoint;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreGraphics;
// Mappings Unified types to MonoTouch types
using nfloat = global::System.Single;
using nint = global::System.Int32;
using nuint = global::System.UInt32;
#endif

using System.CodeDom.Compiler;

namespace JudoPayiOSXamarinSampleApp
{
	[Register ("RootView")]
	partial class RootView
	{
		[Outlet]
		UITableView ButtonTable { get; set; }

		[Outlet]
		NSLayoutConstraint TableHeightConstrant { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableHeightConstrant != null) {
				TableHeightConstrant.Dispose ();
				TableHeightConstrant = null;
			}

			if (ButtonTable != null) {
				ButtonTable.Dispose ();
				ButtonTable = null;
			}
		}
	}
}