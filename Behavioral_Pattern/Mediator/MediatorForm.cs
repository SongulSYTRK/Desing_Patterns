using Behavioral_Pattern.Mediator.Mediator_Example1.Concrete;
using Behavioral_Pattern.Mediator.Mediator_Example1.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Mediator
{
    public partial class MediatorForm : Form
    {
        MediatorPerson mediator;
        public MediatorForm()
        {
            mediator = new MediatorPerson();
        }
        
        private void btnTomota_Click(object sender, EventArgs e)
        {
            TomatoFarmer FarmerAli = new TomatoFarmer(Name = "Ali", unitPrice = 5, mediator);
            TomatoFarmer FarmerMehmet = new TomatoFarmer(Name = "Ali", unitPrice = 6, mediator);
            mediator.FarmerAdd(FarmerAli);
            mediator.FarmerAdd(FarmerMehmet);

            TomatoWholesaler WholeSalerAhmet = new TomatoWholesaler(Name = "Ahmet", UnitPrice = 5, mediator);
            TomatoWholesaler WholeSalerKamil = new TomatoWholesaler(Name = "kamil", UnitPrice = 6, mediator);
            mediator.WholesalerAdd(WholeSalerAhmet);
            mediator.WholesalerAdd(WholeSalerKamil);

            WholeSalerAhmet.BuyProduct();

            FarmerAli.SellProduct();
        }
    }
}
