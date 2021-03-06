﻿using System;
using Foundation;
using UIKit;
#if __UNIFIED__
// Mappings Unified CoreGraphic classes to MonoTouch classes

#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreGraphics;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
// Mappings Unified types to MonoTouch types
using nfloat = global::System.Single;
using nint = global::System.Int32;
using nuint = global::System.UInt32;
#endif

namespace JudoDotNetXamariniOSSDK.Views.TableCells.Card
{
	public partial class ReassuringTextCell : CardCell
	{
		public static readonly UINib Nib = UINib.FromName ("ReassuringTextCell", NSBundle.MainBundle);


		public ReassuringTextCell (IntPtr handle) : base (handle)
		{
			Key = "ReassuringTextCell";
		}

		public override CardCell Create ()
		{
			return (ReassuringTextCell)Nib.Instantiate (null, null) [0];
		}


		public override void DismissKeyboardAction ()
		{

		}

		public override void SetUpCell ()
		{

		}

	}
}
