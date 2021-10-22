using Creational_Pattern.Factory.Factory_Example1.Enums;
using Creational_Pattern.Factory.Factory_Example1.FactoryCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern.Factory.Factory_Example1
{
    public partial class CreateComputor : Form
    {
        public CreateComputor()
        {
            InitializeComponent();
        }

        private void btncomputerCreate_Click(object sender, EventArgs e)
        {
            Creator creator = new Creator();
            IComputer computerLenova= Creator.FactoryCreator(ComputerModel.Lenova);
            MessageBox.Show($"computer : {computerLenova}");

        }
    }
}
