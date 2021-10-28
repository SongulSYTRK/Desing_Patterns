using System;
using System.Collections.Generic;
using System.Text;

namespace CoR_Hospital.Model
{
    public class SickBill
    {
        public List<PaymentBill> Payable = new List<PaymentBill>();

        public List<PaymentBill> Paid = new List<PaymentBill>();

        public IList<Inspection> inspections { get; } = new List<Inspection>();
        
    }
}
