using Behavioral_Pattern.Mediator.Mediator_Example1.Abstrcat;
using Behavioral_Pattern.Mediator.Mediator_Example1.Enums;
using Behavioral_Pattern.Mediator.Mediator_Example1.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Mediator.Mediator_Example1.Concrete
{
    public class MediatorPerson : IMediator
    {
        public List<BaseFarmers> Farmerlist;
        public List<BaseWholesaler> Wholesalerlist;
        public MediatorPerson()
        {
            Farmerlist = new List<BaseFarmers>();
            Wholesalerlist = new List<BaseWholesaler>();
        }
        public void BuyFromFarmer(BaseFarmers farmer)
        {
            BaseWholesaler wholesaler = Suitablewholesaler(farmer.vegetable);
            MessageBox.Show($"from {farmer.Name} to {wholesaler.Name}");
        }

        public void FarmerAdd(BaseFarmers farmer)
        {
            Farmerlist.Add(farmer);
        }

        public void SellToWholesaler(BaseWholesaler Wholesaler)
        {
            BaseFarmers farmer = SuitableFarmer(Wholesaler.vegetable);
            MessageBox.Show($"from {farmer.Name} to {Wholesaler.Name}");
        }

        public void WholesalerAdd(BaseWholesaler Wholesaler)
        {
            Wholesalerlist.Add(Wholesaler);
        }
        public BaseWholesaler Suitablewholesaler(Vegetable vegatable)
        {
            BaseWholesaler Suitablewholesaler = null;

            foreach (BaseWholesaler wholesaler in Wholesalerlist)
            {
                if (vegatable == wholesaler.vegetable)
                {
                    decimal farmerprice = wholesaler.UnitPrice;

                    if (Suitablewholesaler.UnitPrice.CompareTo(wholesaler.UnitPrice) < 0)
                    {
                        Suitablewholesaler = wholesaler;
                    }

                }

            }
            return Suitablewholesaler;
        }
        public BaseFarmers  SuitableFarmer(Vegetable vegatable)
        {
            BaseFarmers Suitablefarmer = null;

            foreach (BaseFarmers farmer in Farmerlist)
            {
                if (vegatable== farmer.vegetable)
                {
                    decimal farmerprice = farmer.UnitPrice;

                    if(Suitablefarmer.UnitPrice.CompareTo(farmer.UnitPrice)> 0)
                    {
                        Suitablefarmer = farmer;
                    }
                   
                }
                
            }
            return Suitablefarmer;

        }
       
    }
}
