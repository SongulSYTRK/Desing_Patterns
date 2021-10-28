using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Abstract;
using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithDraw withDraw = new WithDraw(int.Parse(txtcustomerID.Text), int.Parse(txtAmount.Text));

            BaseEmployee cashier = new Cashier();
            BaseEmployee manager = new Manager();
            BaseEmployee supervisor = new Supervisor();


            cashier.SetNextApprover(supervisor);
            supervisor.SetNextApprover(manager);

           cashier.ProcessRequest(withDraw);
        


        }
    }
}
