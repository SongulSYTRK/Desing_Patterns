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
    public class BankCartHandler : BaseHandler
    {
        public BankCardProcessConcrete bankCardProcessConcrete = new BankCardProcessConcrete();
        public override void HandlerExpense(SickBill sickBill)
        {
            if(sickBill.Payable.Any(x=>x.paymentInformation== PaymentInformation.BankCart))
            {
                Console.WriteLine("Paid by bankcart");
                bankCardProcessConcrete.ResultOfPayment(sickBill);
            }
            else
            {
                _nextHandler.HandlerExpense(sickBill);
            }
        }
    }
}
