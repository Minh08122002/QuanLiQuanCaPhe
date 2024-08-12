using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImageToByte
    {
        public byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, img.RawFormat);
                return m.ToArray();
            }

        }
        public void byteArrayToImage(byte[] byteArrayIn, ref Image returnImage)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
        }
    }
}
