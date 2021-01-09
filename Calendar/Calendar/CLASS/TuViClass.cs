using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;

namespace LunnarSample
{
    class TuViClass
    {
        private static string FileTextNam(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"TuVi\Nam\", fileName);
            return filePath;
        }

        private static string FileTextNu(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"TuVi\Nu\", fileName);
            return filePath;
        }
        public static string[] Can = { "Giap", "At", "Binh", "Dinh", "Mau", "Ky", "Canh", "Tan", "Nham", "Quy" };
        public static string[] Chi = { "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui", "Than", "Dau", "Tuat", "Hoi" };
        //GT = 1 là nữ
        //GT = 0 là nam
        public static string GetTuVi(DateTime date, int GT)
        {
            string line = "";
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            LunnarCalendar lunnar = new LunnarCalendar();
            string sCan = lunnar.GetCanNam(luni.Year);
            string sChi = lunnar.GetChiNam(luni.Year);
            string sCanFile = "";
            string sChiFile = "";
            string filetext = "";

            switch (sCan)
            {
                case "Giáp":
                    sCanFile = Can[0];
                    break;
                case "Ất":
                    sCanFile = Can[1];
                    break;
                case "Bính":
                    sCanFile = Can[2];
                    break;
                case "Đinh":
                    sCanFile = Can[3];
                    break;
                case "Mậu":
                    sCanFile = Can[4];
                    break;
                case "Kỷ":
                    sCanFile = Can[5];
                    break;
                case "Canh":
                    sCanFile = Can[6];
                    break;
                case "Tân":
                    sCanFile = Can[7];
                    break;
                case "Nhâm":
                    sCanFile = Can[8];
                    break;
                case "Quý":
                    sCanFile = Can[9];
                    break;
                default:
                    break;
            }
            switch(sChi)
            {
                case "Tý":
                    sChiFile = Chi[0];
                    break;
                case "Sửu":
                    sChiFile = Chi[1];
                    break;
                case "Dần":
                    sChiFile = Chi[2];
                    break;
                case "Mão":
                    sChiFile = Chi[3];
                    break;
                case "Thìn":
                    sChiFile = Chi[4];
                    break;
                case "Tỵ":
                    sChiFile = Chi[5];
                    break;
                case "Ngọ":
                    sChiFile = Chi[6];
                    break;
                case "Mùi":
                    sChiFile = Chi[7];
                    break;
                case "Thân":
                    sChiFile = Chi[8];
                    break;
                case "Dậu":
                    sChiFile = Chi[9];
                    break;
                case "Tuất":
                    sChiFile = Chi[10];
                    break;
                case "Hợi":
                    sChiFile = Chi[11];
                    break;
                default:
                    break;
            }

            if(GT == 1)
            {
                filetext = string.Format("{0}{1}Nu.txt", sCanFile, sChiFile);
                StreamReader streamReader = new StreamReader(FileTextNu(filetext), Encoding.UTF8);
                line = streamReader.ReadToEnd();
            }
            else
            {
                filetext = string.Format("{0}{1}Nam.txt", sCanFile, sChiFile);
                StreamReader streamReader = new StreamReader(FileTextNam(filetext), Encoding.UTF8);
                line = streamReader.ReadToEnd();
            }
            return line;
        }
    }
}
