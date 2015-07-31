﻿
using System;

using Foundation;
using UIKit;
using System.Collections.Generic;

namespace JudoDotNetXamariniOSSDK
{
	public partial class PaymentReceipt : UIViewController
	{
		private PaymentReceiptViewModel _receipt;

		private List<ReceiptStringItemCell> CellsToShow { get; set; }

		public PaymentReceipt (PaymentReceiptViewModel receipt) : base ("PaymentReceipt~iphone", null)
		{
			_receipt = receipt;
		}



		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SetUpTableView ();
			this.View.BackgroundColor = new UIColor(245f, 245f, 245f,1f);
			HomeButton.TouchUpInside += (sender, ev) => {
				this.DismissViewController(true,null);
			};

		}
			
		void SetUpTableView ()
		{
			ReceiptStringItemCell dateCell = new ReceiptStringItemCell ();
			dateCell.Label = "Date";
			dateCell.Value = _receipt.CreatedAt.ToLongDateString () + ", " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;

			ReceiptStringItemCell amountCell = new ReceiptStringItemCell (); 
			amountCell.Label ="Amount";
			amountCell.Value = _receipt.OriginalAmount + " " + _receipt.Currency;

			CellsToShow = new List<ReceiptStringItemCell> (){ dateCell, amountCell };

		
			ReceiptTableViewSource tableSource = new ReceiptTableViewSource (CellsToShow.ToArray());
			ReceiptTableView.Source = tableSource;
			ReceiptTableView.ScrollEnabled = false;
			float height = tableSource.GetTableHeight();


			TableVIewHeight.Constant = height;
		}
	}
}

