using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR_Hospital.Model
{
    public class SickBill
    {
        public Dictionary<Inspection, int> LineItems { get; } = new Dictionary<Inspection, int>();
        public List<PaymentBill> Payable = new List<PaymentBill>();

        public List<PaymentBill> Paid = new List<PaymentBill>();
        public decimal AmountDue => LineItems.Sum(Inspection => Inspection.Key.Price * Inspection.Value) - Paid.Sum(PaymentBill => PaymentBill.Amount);



    }
}
