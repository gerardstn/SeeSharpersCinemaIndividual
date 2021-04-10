using QRCoder;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Theater;
using SeeSharpersCinema.Models.Program;
using System;
using System.Drawing;
using System.IO;

namespace SeeSharpersCinema.Models.Order
{
    public class Ticket
    {
        public long Id { get; set; }
        public Movie Movie { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public string Cashier { get; set; }
        public string Coupon { get; set; }
        public double Price { get; set; }


        public double BasePrice = 8.5;
        public double LongMovieAddition = 0.5;
        public double ThreeDimensionalAddition = 2.5;

        public double TotalPrice()
        {
            double price = BasePrice;
            if (Movie.IsLongMovie)
            {
                price += LongMovieAddition;
            }

            if (Movie.IsThreeDimensional)
            {
                price += ThreeDimensionalAddition;
            }
            return price;
        }
        public bool isThreeDimensional() => Movie.Technique == "3D";

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
