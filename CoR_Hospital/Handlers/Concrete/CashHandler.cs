using CoR_Hospital.Handlers.Abstract;
using CoR_Hospital.Model;
using CoR_Hospital.Model.Enums;
using CoR_Hospital.PaymmentProcessor.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR_Hospital.Handlers.Concrete
{
    public class CashHandler : BaseHandler
    {
        public CashProcessConcrete cashProcessConcrete = new CashProcessConcrete();

        public override void HandlerExpense(SickBill sickBill)
        {
            if (sickBill.Payable.Any(x=>x.paymentInformation== PaymentInformation.Cash))
            {
                Console.WriteLine("The bill paid by cash");
                cashProcessConcrete.ResultOfPayment(sickBill);
                
            }
            else 
            {
                _nextHandler.HandlerExpense(sickBill);
            }
        }
    }
}
