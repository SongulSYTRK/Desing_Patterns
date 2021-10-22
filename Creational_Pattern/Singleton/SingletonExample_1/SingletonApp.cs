using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Creational_Patterns.Singleton;

namespace Creational_Pattern.Singleton
{
    public partial class SingletonApp : Form
    {
        public SingletonApp()
        {
            InitializeComponent();
        }

        private void SingletonApp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            //   Singleton singleton = new Singleton();  // singleton nesnesi oluşturduk . Constructor private yapıldığı için bu nesnemize ulaşamayız ve nesne oluşturamayız 


            Singletonn singleton = Singletonn.getSingleton();  //Nesnemize ulaşabilmek için singleton methodu kullanarak nesnemizi oluşturabiliriz


        }
    }
}
