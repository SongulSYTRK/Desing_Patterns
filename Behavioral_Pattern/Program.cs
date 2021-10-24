using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example1;
using Behavioral_Pattern.Observer.Observer_Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ObserverForm());
        }
    }
}
