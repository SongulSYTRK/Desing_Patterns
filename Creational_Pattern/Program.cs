using Creational_Pattern.Builder;
using Creational_Pattern.Factory.Factory_Example1;
using Creational_Pattern.Factory.Factory_Example2;
using Creational_Pattern.Singleton;
using Creational_Pattern.Singleton.SingletonExample_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Pattern
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
            Application.Run(new Furniture());
        }
    }
}
