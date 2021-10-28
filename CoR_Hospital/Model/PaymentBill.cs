using CoR_Hospital.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoR_Hospital.Model
{
    public class PaymentBill
    {
        public decimal amount { get; set; }
        public PaymentInformation paymentInformation { get; set; }
    }
}
