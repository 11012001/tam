using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunnarSample
{
    class _12ConGiap
    {
        private static Image loadImage(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"12ConGiap\", fileName);
            Image image = new Bitmap(filePath);
            return image;
        }
        public static Image Ty;
        public static Image Suu;
        public static Image Dan;
        public static Image Mao;
        public static Image Thin;
        public static Image Ti;
        public static Image Ngo;
        public static Image Mui;
        public static Image Than;
        public static Image Dau;
        public static Image Tuat;
        public static Image Hoi;
        public static void DrawImage()
        {
            Ty = loadImage("Ty.png");
            Suu = loadImage("Suu.png");
            Dan = loadImage("Dan.png");
            Mao = loadImage("Mao.png");
            Thin = loadImage("Thin.png");
            Ti = loadImage("Ti.png");
            Ngo = loadImage("Ngo.png");
            Mui = loadImage("Mui.png");
            Than = loadImage("Than.png");
            Dau = loadImage("Dau.png");
            Tuat = loadImage("Tuat.png");
            Hoi = loadImage("Hoi.png");
        }
    }
}
