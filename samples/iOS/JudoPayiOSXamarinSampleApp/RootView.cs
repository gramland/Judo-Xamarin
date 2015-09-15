﻿
using System;

using Foundation;
using UIKit;
using JudoDotNetXamariniOSSDK;
using System.Drawing;
using System.Collections.Generic;
using CoreGraphics;

namespace JudoPayiOSXamarinSampleApp
{
	public partial class RootView : UIViewController
	{
		SlideUpMenu menu;
		public RootView () : base ("RootView", null)
		{
			
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SetUpTableView ();

			UILabel label = new UILabel (new CGRect (0, 0, 120f, 30f));
			label.TextAlignment = UITextAlignment.Center;
			label.Font =UIFont.FromName("Courier", 17.0f);
			label.BackgroundColor = UIColor.Clear;

			label.Text = "Judo Sample App";
			this.NavigationController.NavigationBar.TopItem.TitleView = label;
			
		}


		void SetUpTableView ()
		{
			UITableViewCell cell = new UITableViewCell ();

			Dictionary<string,Action> buttonDictionary = new Dictionary<string,Action> ();

			buttonDictionary.Add ("Make a Payment", ()=> {    	
				var creditCardView = JudoSDKManager.GetPaymentView ();

				if(UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
				{
						
					creditCardView.ModalPresentationStyle = UIModalPresentationStyle.FormSheet;
					creditCardView.ModalTransitionStyle = UIModalTransitionStyle.CoverVertical;

					this.PresentViewController(creditCardView, true, null);
		
				}
				else
				{
					this.NavigationController.PushViewController (creditCardView, true);
				}
			});

			buttonDictionary.Add ("PreAuthorise", delegate  {				
				var preAuthoriseView =JudoSDKManager.GetPreAuthView();
				this.NavigationController.PushViewController(preAuthoriseView,true);
			});

			buttonDictionary.Add ("Token Payment", delegate {				
				var tokenPaymentView =JudoSDKManager.GetTokenPaymentView();
				this.NavigationController.PushViewController(tokenPaymentView,true);
			});

			buttonDictionary.Add ("Token PreAuthorise", delegate {				
				var tokenPreAuth =JudoSDKManager.GetTokenPreAuthView();
				this.NavigationController.PushViewController(tokenPreAuth,true);
			});


			MainMenuSource menuSource = new MainMenuSource (buttonDictionary);
			ButtonTable.Source = menuSource;
			TableHeightConstrant.Constant = menuSource.GetTableHeight ()+60f;

		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		 	menu = new SlideUpMenu (new RectangleF(0,(float)this.View.Frame.Bottom-40f,(float)this.View.Frame.Width,448f));
			menu.AwakeFromNib ();
			menu.AutoresizingMask = UIViewAutoresizing.FlexibleMargins;
			this.View.AddSubview (menu);
		}

		public override void ViewWillDisappear (bool animated)
		{
			menu.RemoveFromSuperview ();
			base.ViewWillDisappear (animated);
		}

		public override void DidRotate (UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate (fromInterfaceOrientation);
			menu.ResetMenu ();
		}
	}
}

