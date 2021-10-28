using CoR_Hospital.Handlers.Concrete;
using CoR_Hospital.Model;
using CoR_Hospital.Model.Enums;
using System;
using System.Collections.Generic;

namespace CoR_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            
            var  sickBill = new SickBill();
            

            sickBill.Payable.Add(new PaymentBill {paymentInformation=PaymentInformation.Cash , amount=1000});
            sickBill.Payable.Add(new PaymentBill { paymentInformation = PaymentInformation.BankCart, amount = 5000 });
            sickBill.Payable.Add(new PaymentBill { paymentInformation = PaymentInformation.Creditcart, amount = 35000 });

            sickBill.Paid.Add(new PaymentBill { paymentInformation = PaymentInformation.Cash, amount = 3000 });
            sickBill.Paid.Add(new PaymentBill { paymentInformation = PaymentInformation.BankCart, amount = 4000 });
            sickBill.Paid.Add(new PaymentBill { paymentInformation = PaymentInformation.Creditcart, amount = 7000 });


            sickBill.inspections.Add(new Inspection { Id = 1, Name = "Dentist", Price = 500 });
            sickBill.inspections.Add(new Inspection { Id = 2, Name = "Heart", Price = 3500 });
            sickBill.inspections.Add(new Inspection { Id = 3, Name = "Surgery", Price = 5000 });

            List<SickBill> sickBills = new List<SickBill>();

            CashHandler cashHandler = new CashHandler();
            BankCartHandler bankCartHandler = new BankCartHandler();
            CreditCartHandler creditCartHandler = new CreditCartHandler();


            cashHandler.SetHandler(bankCartHandler);
            bankCartHandler.SetHandler(creditCartHandler);

             Console.WriteLine("ödeme bekliyor");
            foreach (var item in sickBills)
            {
                bankCartHandler.SetHandler(item.);
            }


            cashHandler.HandlerExpense(sickBill);
            Console.ReadKey();

            #endregion
        }
    }
}
