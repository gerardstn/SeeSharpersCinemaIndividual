﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using QRCoder;
using System.IO;

namespace SeeSharpersCinema.Models
{
    public class EmailService
    {
        private const String cinemaEmail    = "SeeSharpersCinema@gmail.com";
        private const String cinemaEmailPw  = "SeeSharpersCinema1!";
        private const String emailClient    = "smtp.gmail.com";

        public void email_send()
        {
            SeeSharpersCinema.Models.Order.Ticket ticket = new SeeSharpersCinema.Models.Order.Ticket();
            Guid guid = Guid.NewGuid();
            String qrCodew = ticket.GetQr();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.google.com", QRCodeGenerator.ECCLevel.Q);
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(guid.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            Byte[] bytee;

            using (MemoryStream stream = new MemoryStream())
            {
                qrCodeImage.Save("D:\\Avans\\Temp\\QRCode_" + guid + ".png");
                bytee = stream.ToArray();
            }

            string emailBody = @"<html>
                      <body>
                      <p>Beste (Customer),</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Met vriendelijke groet,<br>-SeeSharpersCinema</br></p>
                      </body>
                      </html>
                     ";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(cinemaEmail);

                //Mail TO customer email
                mail.To.Add("SeeSharpersCinema@gmail.com");

                //Add name and moviename from purchase information
                mail.Subject = "Thank you " + "(name)" + " for ordering a ticket for movie " + "(moviename)";

                mail.Body = emailBody;
                mail.IsBodyHtml = true;

                //Attach Generated PNG from QR code.
                mail.Attachments.Add(new Attachment("D:/Avans/Temp/QRCode_" + guid + ".png"));

                //Set mail client
                using (SmtpClient smtp = new SmtpClient(emailClient, 587))
                {
                    smtp.Credentials = new NetworkCredential(cinemaEmail, cinemaEmailPw);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}