using CoR_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoR_Hospital.Handlers.Abstract
{
   public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public void SetHandler(BaseHandler nextHandler) => _nextHandler = nextHandler;
        public abstract void HandlerExpense(SickBill sickBill);
    }
}
