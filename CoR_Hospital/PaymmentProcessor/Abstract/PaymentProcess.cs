using CoR_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoR_Hospital.PaymmentProcessor.Abstract
{
    public abstract class PaymentProcess
    {
        public abstract void ResultOfPayment(SickBill sickBill);
    }
}
