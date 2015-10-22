﻿using System;
using JudoPayDotNet.Logging;
using PassKit;
using Foundation;
using System.Threading.Tasks;
using JudoPayDotNet.Models;

namespace JudoDotNetXamariniOSSDK
{
	public partial class JudoPKPaymentAuthorizationViewControllerDelegate :NSObject, IPKPaymentAuthorizationViewControllerDelegate
	{
		IApplePayService _applePayService ;
		NSDecimalNumber _runningTotal;
		public JudoPKPaymentAuthorizationViewControllerDelegate (IApplePayService applePayService, PKPaymentRequest request)
		{
			_applePayService = applePayService;
			_runningTotal = request.PaymentSummaryItems [request.PaymentSummaryItems.Length-1].Amount;
		}



		public void DidAuthorizePayment (PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion)
		{

			ClearPaymentWithJudo (payment, completion);
		//	completion.BeginInvoke(PKPaymentAuthorizationStatus.Success,
//			_applePayService.HandlePKPayment (payment).ContinueWith (reponse => {
//				var result = reponse.Result;
//				if (result != null && !result.HasError && result.Response.Result != "Declined") {
//				//var paymentreceipt = result.Response as PaymentReceiptModel;
//				}
//				else
//				{
//					//completion.
//				}
//			});
		}


		public void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller)
		{
			controller.DismissViewController (true, null);
		}

		public void WillAuthorizePayment (PKPaymentAuthorizationViewController controller)
		{
			
		}

		 async Task ClearPaymentWithJudo (PKPayment payment, Action<PKPaymentAuthorizationStatus> completion) 
		{
			IResult res;
			var response = await _applePayService.HandlePKPayment (payment,_runningTotal);
			completion.BeginInvoke (PKPaymentAuthorizationStatus.Failure,null,null);
			//InvokeOnMainThread (() => EndDelegate (response.Response,completion));
		//	EndDelegate (response.Response,completion);
		}


		public void EndDelegate(ITransactionResult result,Action<PKPaymentAuthorizationStatus> completion)
		{
//			case for all the results, calls the completion stuff
//
//				calls judo success or fall delegate
			}


	}
}
