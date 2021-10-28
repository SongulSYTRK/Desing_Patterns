using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Abstract
{
    public abstract class BaseFurniture
    {
        public abstract string ShipForm();
        public int Id { get; set; }
        public decimal   Amount { get; set; }

    }
}
