using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Title { get; set; }
        public DateTime TimeSlot { get; set; }
        public int RoomID { get; set; }
        public int SeatNum { get; set; }
        public bool Discounted { get; set; }


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
