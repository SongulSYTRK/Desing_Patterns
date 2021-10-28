using Creational_Pattern.Factory.Factory_Example2.Abstract;
using Creational_Pattern.Factory.Factory_Example2.Decorator.Abstract;
using Creational_Pattern.Factory.Factory_Example2.Decorator.Concrete;
using Creational_Pattern.Factory.Factory_Example2.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern.Factory.Factory_Example2
{
    public partial class Furniture : Form
    {
        public Furniture()
        {
            InitializeComponent();
        }

        private void btnseat_Click(object sender, EventArgs e)
        {
            FactoryFurniture factoryFurniture = new FactoryFurniture();
            BaseFurnitureDecorator baseFurnitureDecorator;

            BaseFurniture baseFurniture;
                
                decimal amount = decimal.Parse(txtAmount.Text);
                
                baseFurniture = factoryFurniture.Factoryfurniture( amount ); // factory design pattern uyguladık
            baseFurnitureDecorator = new AddColor(baseFurniture); //Dekorator yaptık 
            MessageBox.Show($"This Product Name :  {baseFurniture.GetType().Name} \n ShipFrom :  {baseFurnitureDecorator.ShipForm()} \n Amount: {amount} ");

            
        }
    }
}
