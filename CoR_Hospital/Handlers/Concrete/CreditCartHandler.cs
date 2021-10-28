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
    public class CreditCartHandler : BaseHandler
    {
        public CreditCartProcessConcrete creditCardProcessConcrete = new CreditCartProcessConcrete();
        public override void HandlerExpense(SickBill sickBill)
        {
            
        
            if (sickBill.Payable.Any(x => x.paymentInformation == PaymentInformation.Creditcart))
            {
                Console.WriteLine("Paid by credicart");
                creditCardProcessConcrete.ResultOfPayment(sickBill);
            }
            else
            {
                Console.WriteLine("Card blocked");
            }
        
    }
    }
}
