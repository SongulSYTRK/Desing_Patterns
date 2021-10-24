using Behavioral_Pattern.Mediator.Mediator_Example1.Enums;
using Behavioral_Pattern.Mediator.Mediator_Example1.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Mediator.Mediator_Example1.Abstrcat
{
   public abstract  class BaseFarmers
    {
        public string  Name { get; set; }
        public Vegetable vegetable { get; set; }
        public int UnitPrice { get; set; }

        public IMediator mediator { get; set; }
        public void SellProduct() => mediator.BuyFromFarmer(this); 
    }
}
