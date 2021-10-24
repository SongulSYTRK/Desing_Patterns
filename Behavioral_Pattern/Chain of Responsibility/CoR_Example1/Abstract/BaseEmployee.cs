using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Abstract
{
   public abstract  class BaseEmployee
    {
        protected BaseEmployee NextApprover;

        public void SetNextApprover(BaseEmployee superisor)
        {
            this.NextApprover = superisor;
        }

        //Kriter yakalanınca çalışcak method 
        public abstract void ProcessRequest(WithDraw requst);
    }
}
