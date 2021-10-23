using Structural_Patterns.Bridge.Bridge_Example1.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Bridge.Bridge_Example1
{
    public partial class AppUserForm : Form
    {
        public AppUserForm()
        {
            InitializeComponent();
        }

        private void btnlistenmusic_Click(object sender, EventArgs e)
        {
            Music music = new Music("Ed Sheeran", "Bad Habit");
            ComputerHF computerHF = new ComputerHF();
            
            MessageBox.Show(computerHF.PlayMusic(music));
        }
    }
}
