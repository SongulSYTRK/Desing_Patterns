using Structural_Patterns.Decorator.Abstract;
using Structural_Patterns.Decorator.Decorator_Example1.DecoratorConcrete;
using Structural_Patterns.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Decorator.Decorator_Example1
{
    public partial class CoffeeForm : Form
    {
        ICoffee coffee;
        public CoffeeForm()
        {
            InitializeComponent();
            coffee = new Coffee();
            
        }
       
        private void btnCoffee_Click(object sender, EventArgs e)
        {

            string CoffeeName = "Latte";
            CoffeeSize CoffeeSize = CoffeeSize.Medium;
            CaramelCoffee Caramelcoffe = new CaramelCoffee(coffee);
            MessageBox.Show($"{CoffeeName} \n {CoffeeSize}");
            Caramelcoffe.Hot();
            
        }

        private void btnMilkCoffee_Click(object sender, EventArgs e)
        {
            string CoffeeName = "Latte";
            CoffeeSize CoffeeSize = CoffeeSize.Large;
            MilkCoffee Milkcoffee = new MilkCoffee(coffee);
            MessageBox.Show($"{CoffeeName} \n {CoffeeSize}");
            Milkcoffee.Hot();
        }

        private void btnMixCoffe_Click(object sender, EventArgs e)
        {
            string CoffeeName = "Latte";
            CoffeeSize CoffeeSize = CoffeeSize.Small;
            Caramel_MilkCoffee Milk_Caramelcoffee = new Caramel_MilkCoffee(coffee);
            MessageBox.Show($"{CoffeeName} \n {CoffeeSize}");
            Milk_Caramelcoffee.Hot();
        }
    }
}
