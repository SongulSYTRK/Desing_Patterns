using Creational_Pattern.Factory.Factory_Example1.Concrete;
using Creational_Pattern.Factory.Factory_Example1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern.Factory.Factory_Example1.FactoryCreator
{
   public  class Creator
    {
       
        public static IComputer FactoryCreator(ComputerModel computerModel)
        {
            IComputer computer=null;

            if (computerModel == ComputerModel.Mac)
            {
                computer = new Mac();
            }
            else if (computerModel == ComputerModel.Lenova)
            {
                computer = new Lenova();
            }
            else if (computerModel == ComputerModel.Dell)
            {
                computer = new Dell();
            }
            else
            {
                MessageBox.Show("Dont have type of computer ");
            }

            return computer;
        }
    }
}
