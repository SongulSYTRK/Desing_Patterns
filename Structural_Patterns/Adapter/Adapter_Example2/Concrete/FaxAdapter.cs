using Structural_Patterns.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Adapter.Concrete
{
    public class FaxAdapter : IError
    {
        private Fax _fax;

        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }
        public string ErrorDescription 
        {
            get => _fax.ErrorDescription;
            set => _fax.ErrorDescription = value;
        }
       

        public int ErrorNumber
        {
            get => _fax.FaxErrorCode;
            set => _fax.FaxErrorCode= value;
        }

        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("songulsytrk@gmail.com");
                mail.Subject = "FaxError ";
                mail.Body = "Device have Faxerror";
                mail.To.Add("songulsytrk@gmail.com");


                SmtpClient mailClient = new SmtpClient();
                mailClient.Credentials = new System.Net.NetworkCredential("songuslytrk@gmail.com", "Enter password");
                mailClient.EnableSsl = true;
                mailClient.Host = "smpt.gmail.com";
                mailClient.Port = 587;
                mailClient.Send(mail);
                MessageBox.Show("ErrorMessage went ");
            }
            catch (Exception)
            {

                MessageBox.Show("ErrorMessage didnt go to the  mail  ");
            }
        }
    }
}
