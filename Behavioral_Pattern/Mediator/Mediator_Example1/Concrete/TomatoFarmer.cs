using Behavioral_Pattern.Mediator.Mediator_Example1.Abstrcat;
using Behavioral_Pattern.Mediator.Mediator_Example1.Enums;
using Behavioral_Pattern.Mediator.Mediator_Example1.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Mediator.Mediator_Example1.Concrete
{
    public class TomatoFarmer : BaseFarmers
    {
        public TomatoFarmer(string Name ,  int unitPrice, IMediator mediator )
        {

            this.Name = Name;
            this.vegetable = Vegetable.Tomato;
            this.UnitPrice = unitPrice;

    }
    }
}
