using Creational_Pattern.Builder.Abstract_Builder;
using Creational_Pattern.Builder.Concrete_Builder;
using Creational_Pattern.Builder.Director;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern.Builder
{
    public partial class btn : Form
    {
        public btn()
        {
            InitializeComponent();
        }

        private void btnDominosPizza_Click(object sender, EventArgs e)
        {
            PizzaBuilder pizzaBuilder;
            Director_Customer directorCustomer = new Director_Customer();
            pizzaBuilder = new DominosPizza();

            directorCustomer.GetPizza(pizzaBuilder);
            listBox1.Items.Add( $"Order= {pizzaBuilder.Product_Pizza.ToString()}" );

        }

      
        

        private void btnVegetarianPizza_Click(object sender, EventArgs e)
        {
           ;
            Director_Customer directorCustomer = new Director_Customer();
            PizzaBuilder pizzaBuilder = new VegetarianPizza();
            directorCustomer.GetPizza(pizzaBuilder);
            listBox1.Items.Add($"Order = {pizzaBuilder.Product_Pizza.ToString()}");

        }
    }
}
