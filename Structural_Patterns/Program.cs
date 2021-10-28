using Structural_Patterns.Adapter;
using Structural_Patterns.Bridge.Bridge_Example1;
using Structural_Patterns.Decorator.Decorator_Example1;
using Structural_Patterns.Decorator.Decorator_Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns
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
            Application.Run(new DecoratorStudent());
        }
    }
}
