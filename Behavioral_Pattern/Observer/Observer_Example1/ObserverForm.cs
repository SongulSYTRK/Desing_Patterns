using Behavioral_Pattern.Observer.Observer_Example1.Concrete;
using Behavioral_Pattern.Observer.Observer_Example1.Concrete.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Observer.Observer_Example1
{
    public partial class ObserverForm : Form
    {
        public ObserverForm()
        {
            InitializeComponent();
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            StudentObserverable Student = new StudentObserverable();
            Student.observerAdd(new MotherObserver());
            Student.observerAdd(new FatherObserver());
            Student.StudentId = int.Parse(txtId.Text);
            Student.FirstName = txtName.Text;
            Student.LastName = txtLastname.Text;
            Student.ExamResult = true;
            dataGridView1.DataSource = Student;
            
        }

       
    }
}
