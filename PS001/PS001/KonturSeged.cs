using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS001
{
    public static class KonturSeged
    {
        public static Bitmap Konturozott(Bitmap bmp, int Limit)
        {
            Bitmap ujbmp = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 1; i < bmp.Width; i++)
            {
                for (int j = 1; j < bmp.Height; j++)
                {
                    if (Math.Abs(bmp.GetPixel(i - 1, j).ToArgb() - bmp.GetPixel(i, j).ToArgb()) > Limit)
                    {
                        ujbmp.SetPixel(i, j, Color.Black);
                    }
                    if (Math.Abs(bmp.GetPixel(i, j - 1).ToArgb() - bmp.GetPixel(i, j).ToArgb()) > Limit)
                    {
                        ujbmp.SetPixel(i, j, Color.Black);
                    }
                }
            }
            return ujbmp;
        }
    }
}
