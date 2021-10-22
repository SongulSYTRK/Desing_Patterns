using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns.Singleton
{
    public class App
    {
       //   Singleton singleton = new Singleton();  // singleton nesnesi oluşturduk 
        Singleton singleton = Singleton.getSingleton();  //singleton methodu kullanarak nesnemizi oluşturabiliriz
    }
}
