using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern.Singleton.SingletonExample_2
{
    public partial class SingletonProperty : Form
    {
        public SingletonProperty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CreateSingleton.CreateObject.GetCreateObject());
        }

        private void SingletonProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
