﻿
using System;

using Foundation;
using UIKit;

namespace JudoDotNetXamariniOSSDK
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