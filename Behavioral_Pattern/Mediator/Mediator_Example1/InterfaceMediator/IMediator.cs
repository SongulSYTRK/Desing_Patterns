using Behavioral_Pattern.Mediator.Mediator_Example1.Abstrcat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Mediator.Mediator_Example1.Mediator
{
   public  interface IMediator
    {
        // ekstra yeni bir üretici yada toptancıyla çalışmaya başlayabilir. Bu yüzden bunları ekleyebilir 
        void FarmerAdd(BaseFarmers farmer);
        void WholesalerAdd(BaseWholesaler Wholesaler);

        void BuyFromFarmer(BaseFarmers farmer);
        void SellToWholesaler(BaseWholesaler Wholesaler);
    }
}
