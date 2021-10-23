using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Adapter.Concrete
{
    public class Fax
    {
        //fax sınıfım diğer sınıflarımdan farklı bir şekilde hata mesajı veriyor ama ben tüm sınfılarımdan bir arada hata mesajı almak istiyorum . Bunun için 2 sınıf arasında bağlantı sağlamak için FaxAdapter.cs oluştururakk bu sınıfımında interfaceleri kullanarak hata messajı gönderme gibi işlemleri yaparak diğer sınıflara adaptasyonunu sağladım

        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string  FaxSend() => "Fax send ";
        public string FaxGet() => "Fax get ";

    }
}
