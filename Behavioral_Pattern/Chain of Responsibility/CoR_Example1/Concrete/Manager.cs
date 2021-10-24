using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1.Concrete
{
    public class Manager : BaseEmployee
    {
        public override void ProcessRequest(WithDraw requst)
        {
            if (requst.Amount > 10000 && requst.Amount <30000)
            {
                MessageBox.Show($"We gave {requst.Amount}$ to {requst.CustomerId} by manager");
            }
            else if (NextApprover != null)
            {
                MessageBox.Show($"Directed to the manager because the {requst.Amount}$ is too high  ");
                NextApprover.ProcessRequest(requst);
            }
            else
            {
                MessageBox.Show($"we dont give {requst.Amount}$ ");
            }
        }
    }
}
