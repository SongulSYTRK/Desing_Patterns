using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Abstract
{
   public  class WithDraw
    {
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public WithDraw(int Amount , int CustomerId)
        {
            this.Amount = Amount;
            this.CustomerId = CustomerId;
        }
     

    }
    
}
