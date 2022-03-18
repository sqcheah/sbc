using System;
using System.Linq;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    static class Program
    {//https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
        public static ApplicationContext AppContext { get; set; }
        public static string username;
        public static int userID;
        public static int providerID = 1;
        public static string Conn = "datasource=localhost;port=3306;username=root;password=;database=busbooking;sslMode=none;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.AppContext = new ApplicationContext(new FormStart());
            Application.Run(AppContext);
        }
        //helper method to switch forms
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            oldMainForm?.Close();
            newForm.Show();
        }
        //calculate width to gent cente
        //shud add margin?
        public static int calculateWidth(Control parent, Control child)
        {
            return (parent.Width - parent.Padding.Left - parent.Padding.Right - child.Width) / 2;
        }
        public static string encryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static string GenerateRandomString(int strLength)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz@#$&ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, strLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        /*
        //https://stackoverflow.com/questions/2031824/what-is-the-best-way-to-check-for-internet-connectivity-using-net
        public static bool CheckForInternetConnection()
{
    try
    {
        using (var client = new WebClient())
            using (client.OpenRead("http://google.com/generate_204")) 
                return true; 
    }
    catch
    {
        return false;
    }
}
       private void mailTemplate()
       {
           MailAddress from = new MailAddress("Someone@domain.topleveldomain", "Name and stuff");
           MailAddress to = new MailAddress("Someone@domain.topleveldomain", "Name and stuff");
           List<MailAddress> cc = new List<MailAddress>();
           //cc.Add(new MailAddress("Someone@domain.topleveldomain", "Name and stuff"));
           SendEmail("Want to test this damn thing", from, to, cc);
       }

       protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
       {
           string Text = "";
           SmtpClient smtp = new SmtpClient();
           MailMessage msgMail;
           Text = "Stuff";
           msgMail = new MailMessage();
           msgMail.From = _from;
           msgMail.To.Add(_to);
           foreach (MailAddress addr in _cc)
           {
               msgMail.CC.Add(addr);
           }
           if (_bcc != null)
           {
               foreach (MailAddress addr in _bcc)
               {
                   msgMail.Bcc.Add(addr);
               }
           }
           msgMail.Subject = _subject;
           msgMail.Body = Text;
           msgMail.IsBodyHtml = true;
           smtp.Port = 587;
           smtp.Host = "smtp.gmail.com"; //for gmail host  
           smtp.EnableSsl = true;
           smtp.UseDefaultCredentials = false;
           smtp.Credentials = new NetworkCredential("FromMailAddress", "password");
           smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
           smtp.Send(msgMail);
           msgMail.Dispose();
       }*/
    }
}
