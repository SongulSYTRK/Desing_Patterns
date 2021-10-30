using Structural_Patterns.Adapter.Concrete;
using Structural_Patterns.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Adapter
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Fax fax = new Fax { FaxErrorCode = 101, ErrorDescription = " Device has faxerror " };


            IError[] errors =
                {
                new DbError { ErrorNumber = 1001 ,ErrorDescription = " Device has dberror "},
                new TechnicalError{ErrorNumber = 2001 ,ErrorDescription = " Device has technicalerror "},
                new FaxAdapter(fax) // Fax hatamızı adaptör yardımıyla diğer hatalara benzettik hepsini aynı anda alma imkanımız oldu 

                };
           
             dataGridView1.DataSource = errors;
           
                
           
       
        }
    }
}
