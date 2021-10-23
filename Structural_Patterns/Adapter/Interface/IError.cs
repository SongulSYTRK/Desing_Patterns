using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Adapter.Interface
{
   public interface  IError
    {
        int ErrorNumber { get; set; }
        string ErrorDescription { get; set; }
        void SendMail();
    }
}
