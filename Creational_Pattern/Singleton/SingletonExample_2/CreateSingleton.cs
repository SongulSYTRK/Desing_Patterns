using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Singleton.SingletonExample_2
{
  public   class CreateSingleton
    {
        private CreateSingleton() { }
        private static CreateSingleton _createObject;

        //Property olarak instance oluşturduk
        public static CreateSingleton CreateObject
        {
            get
            {

                if (_createObject == null)
                {
                    _createObject = new CreateSingleton();
                   
                }
                return _createObject;
                        
            }
        }
        public string GetCreateObject() => "Object created";
    }
}
