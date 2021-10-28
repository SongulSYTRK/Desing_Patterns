using Creational_Pattern.Factory.Factory_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Decorator.Abstract
{
   public abstract  class BaseFurnitureDecorator:BaseFurniture
    {
        private BaseFurniture _baseFurniture;
        public BaseFurnitureDecorator(BaseFurniture baseFurniture)
        {
            this._baseFurniture = baseFurniture;
        }
    }
}
