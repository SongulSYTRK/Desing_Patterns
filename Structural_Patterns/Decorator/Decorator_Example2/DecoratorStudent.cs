using Structural_Patterns.Decorator.Decorator_Example2.Business.Concrete;
using Structural_Patterns.Decorator.Decorator_Example2.Model.Abstract;
using Structural_Patterns.Decorator.Decorator_Example2.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Decorator.Decorator_Example2
{
    public partial class DecoratorStudent : Form
    {
        public DecoratorStudent()
        {
            InitializeComponent();
        }

        private void btnRecorPrice_Click(object sender, EventArgs e)
        {
            BaseStudent firstStudent = new FirstStudent
            {
                StudentId = int.Parse(txtId.Text),
                Fullname = txtName.Text,
                Departmant = txtdepartmant.Text,
                RecordAmount = decimal.Parse(txtRecord.Text)

            };
            StudentDecorator studentDecorator = new StudentDecorator(firstStudent);
            studentDecorator.Discount = 50;

            MessageBox.Show($"Normally Amount {firstStudent.RecordAmount} but {firstStudent.Fullname} is best  , New price is  {studentDecorator.RecordAmount}");


            
        }

        private void btnGaziAmount_Click(object sender, EventArgs e)
        {
            BaseStudent gaziStudent = new GaziStudent
            {
                StudentId = int.Parse(txtId.Text),
                Fullname = txtName.Text,
                Departmant = txtdepartmant.Text,
                RecordAmount = decimal.Parse(txtRecord.Text)

            };
            StudentDecorator studentDecorator = new StudentDecorator(gaziStudent);
            studentDecorator.Discount = 30;

            MessageBox.Show($"Normally Amount {gaziStudent.RecordAmount} but {gaziStudent.Fullname} is Gazi , New price is  {studentDecorator.RecordAmount}");
        }

      

        private void btnREcord_Click(object sender, EventArgs e)
        {
            BaseStudent Student = new FirstStudent
            {
                StudentId = int.Parse(txtId.Text),
                Fullname = txtName.Text,
                Departmant = txtdepartmant.Text,
                RecordAmount = decimal.Parse(txtRecord.Text)

            };
            MessageBox.Show($"Normally Amount {Student.RecordAmount} ");
        }

        private void DecoratorStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
