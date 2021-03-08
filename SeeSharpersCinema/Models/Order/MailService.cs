using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Drawing;

namespace SeeSharpersCinema.Models
{
    public class EmailService
    {
        private const String cinemaEmail = "SeeSharpersCinema@gmail.com";

        public void email_send()
        {
            SeeSharpersCinema.Models.Order.Ticket ticket = new SeeSharpersCinema.Models.Order.Ticket();
            String qrCode = ticket.GetQr();

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(cinemaEmail);
                //Mail TO customer email
                mail.To.Add("w.vanburik@student.avans.nl");
                //Add name and moviename from purchase information
                mail.Subject = "Thank you " + "(name)" + " for ordering a ticket for movie " + "(moviename)";

               // mail.Body = "<h1>Hello</h1>";
                mail.Body = "<img src=qrCode width=300 height=300 alt=QR code for no - name />";
                 
                mail.IsBodyHtml = true;
                //Attach Generated PNG from QR code.
                mail.Attachments.Add(new Attachment("C:/Users/WesleyB/Downloads/MB-300_Braindumps_Collection.docx"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("SeeSharpersCinema@gmail.com", "SeeSharpersCinema1!");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}