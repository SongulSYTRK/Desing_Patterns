using Creational_Pattern.Factory.Factory_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Concrete
{
    public class Bakery : BaseFurniture
    {
        public Bakery()
        {
        }

        public Bakery(int id, decimal amount)
        {
            this.Id = id;
            this.Amount = amount;
        }
        public override string ShipForm() => "Made in China";

    }
}
