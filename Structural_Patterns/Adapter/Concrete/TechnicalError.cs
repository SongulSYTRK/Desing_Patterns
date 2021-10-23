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
    public class TechnicalError : IError
    {
        private string _errorDescription;
        private int _errorNumber;

        public string ErrorDescription
        {
            get => _errorDescription;
            set => _errorDescription = value;
        }


        public int ErrorNumber
        {
            get => _errorNumber;
            set => _errorNumber = value;
        }
       
        

        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("songulsytrk@gmail.com");
                mail.Subject = "TechnicalError ";
                mail.Body = "Device have technical problem";
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
