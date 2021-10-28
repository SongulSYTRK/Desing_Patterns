using CoR_Hospital.Model;
using CoR_Hospital.Model.Enums;
using CoR_Hospital.PaymmentProcessor.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR_Hospital.PaymmentProcessor.Concrete
{
    public class CreditCartProcessConcrete : PaymentProcess
    {
        public override void ResultOfPayment(SickBill sickBill)
        {
          var payment = sickBill.Payable.FirstOrDefault(x=>x.paymentInformation==PaymentInformation.Creditcart);
                if (payment == null)
                return;
          sickBill.Paid.Add(payment);
        }
    }
}
