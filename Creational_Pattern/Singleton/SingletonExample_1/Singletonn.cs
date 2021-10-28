using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creational_Patterns.Singleton
{
   public  class Singletonn
    {
        //Newlediğimizde constructor üzerinde olacağı için çözümü constructor arıcağız.İlk işimiz constructor'ı private yaparak newlemenin önüne geçeceğiz . Private yaptığımız için nesneyi kendi içinde oluşturmalıyız 
        private Singletonn() 
        {
            MessageBox.Show("Object Created");

        }
        //Dışarı kapalı nesneyi kendisi için oluşturmak için bir method yazabiliriz
        ///(1Yazım )  private Singleton singleton = new Singleton();

        private static Singletonn singleton = new Singletonn();  // Değişkenimizi de static olarak işaretledik 


        // (1. YAZIM)  public Singleton getSingleton() => singleton; // kendi içinde oluşturduğumuz nesneyi dışarı açık hale getirdik. 
        // nesneye method üzerinden eriştik
        public  static Singletonn getSingleton() => singleton;

        //Bir nesneyi newlemeden o methodu kullanamanın yolu o methodu STATİC YAPMAKTIR. Static methodlar içerisinde sadece static değişkenler kullanmaya izin verir bu yüzden class içinde ilk anda hata aldık 
    }
}
