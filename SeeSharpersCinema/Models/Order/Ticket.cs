using Microsoft.AspNetCore.Mvc;
using QRCoder;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Price;
using SeeSharpersCinema.Models.Theater;
using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace SeeSharpersCinema.Models.Order
{
    public class Ticket
    {
        public long TicketID { get; set; }
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public Seat Seat { get; set; }
        public TimeSlot TimeSlot { get; set; }

        public double BasePrice()
        {
            double priceOnDuration = 8.5;
            if (Movie.Duration > 120)
            {
                priceOnDuration = 9;
            }
            return priceOnDuration;
        }

        public bool childrenMovieCheck()
        {
            return Movie.Genre == Genre.Children;
        }
        public bool isThreeD() => Movie.Technique == "3D";

        public string GetQr() => $"data:image/png;base64,{Convert.ToBase64String(GenerateQr(this))}";

        private Byte[] GenerateQr(Ticket ticket)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.google.com", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            return BitmapToBytesCode(qrCodeImage);
        }

        private static Byte[] BitmapToBytesCode(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
