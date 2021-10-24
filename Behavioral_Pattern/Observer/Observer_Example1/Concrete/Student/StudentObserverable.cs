using Behavioral_Pattern.Observer.Observer_Example1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Observer.Observer_Example1.Concrete.Student
{
   public  class StudentObserverable
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        List<IObserver> Observers;
        public StudentObserverable() // contructor oluşturduk 
        {
            this.Observers = new List<IObserver>(); 
        }
        

        public void observerAdd(IObserver observer) => Observers.Add(observer); // isteğe bağlı gözlemci ekle 
        public void observerDelete(IObserver observer) => Observers.Remove(observer); //isteğe bağlı gözlemci çıkar 


        private bool _examResult;

        public bool ExamResult
        {
            get => _examResult;
            set
                {
                if(value==true ) // sınav sonucu açıklannca hepsine haber gidecek
                {
                    
                    _examResult = value;
                    Notify();
                    MessageBox.Show("herkese gitti");
                }
                else
                {
                    _examResult = value;
                    MessageBox.Show("herkese gitmedi");
                }

                }
        }
        public void Notify()   // tüm gözlemcilere haber verecek methodumuz
        {
            Observers.ForEach(O => O.Update());
        }


    }
}
