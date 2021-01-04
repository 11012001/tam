using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunnarSample
{
    class VanKhanString
    {

        #region Văn khấn tết
        private static string FileTextTet(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Tet\", fileName);
            return filePath;
        }
        public static string VKLGT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKLGT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLOT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKLOT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLTM()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKLTM.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLTNM()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKLTNM.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTLM1()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKTLM1.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTN()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKTN.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTTM1()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTet("VKTTM1.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }

        public static string vklgt = "";
        public static string vklot = "";
        public static string vkltm = "";
        public static string vkltnm = "";
        public static string vktlm1 = "";
        public static string vktn = "";
        public static string vkttm1 = "";
        #endregion

        #region Văn khấn khi đi lễ Chùa, Đình, Miếu
        private static string FileTextChua(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Chua\", fileName);
            return filePath;
        }
        public static string VKBCK()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKBCK.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKBTQA()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKBTQA.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKDO()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKDO.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKDTH()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKDTH.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKDTT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKDTT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLP()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKLP.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKMTN()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKMTN.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTH()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKTH.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTMLH()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextChua("VKTMLH.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vkbck = "";
        public static string vkbtqa = "";
        public static string vkdo = "";
        public static string vkdth = "";
        public static string vkdtt = "";
        public static string vklp = "";
        public static string vkmtn = "";
        public static string vkth = "";
        public static string vktmlh = "";
        #endregion

        #region Văn khấn lễ rằm, mồng 1 & các lễ khác
        private static string FileTextRam(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Ram\", fileName);
            return filePath;
        }
        public static string VKLTMRam()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKLTM.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKM1VS15()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKM1VS15.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKRT7()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKRT7.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKRTG()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKRTG.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTDN()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKTDN.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTDTT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKTDTT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTHT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKTHT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKTTT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextRam("VKTTT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vkltmram = "";
        public static string vkm1vs15 = "";
        public static string vkrt7 = "";
        public static string vkrtg = "";
        public static string vktdn = "";
        public static string vktdtt = "";
        public static string vktht = "";
        public static string vkttt = "";
        #endregion

        #region Văn khấn lễ tang, giỗ tổ tiên
        private static string FileTextTang(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Tang\", fileName);
            return filePath;
        }
        public static string VKKDTM()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKKDTM.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLCT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKLCT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLCT49()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKLCT49.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLDT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKLDT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKNCG()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKNCG.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKNGD()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKNGD.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKNGH()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKNGH.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKNGT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextTang("VKNGT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vkkdtm = "";
        public static string vklct = "";
        public static string vklct49 = "";
        public static string vkldt = "";
        public static string vkncg = "";
        public static string vkngd = "";
        public static string vkngh = "";
        public static string vkngt = "";
        #endregion

        #region Văn khấn lễ cưới hỏi & sinh con
        private static string FileTextCuoi(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Cuoi\", fileName);
            return filePath;
        }
        public static string VKCH()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextCuoi("VKCH.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKCM()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextCuoi("VKCM.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vkch = "";
        public static string vkcm = "";
        #endregion

        #region Văn khấn làm nhà, chuyển nhà, tân gia
        private static string FileTextNha(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Nha\", fileName);
            return filePath;
        }
        public static string VKCNSN()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextNha("VKCNSN.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLNT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextNha("VKLNT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLTG()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextNha("VKLTG.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vkcnsn = "";
        public static string vklnt = "";
        public static string vkltg = "";
        #endregion

        #region Các bài văn khấn khác
        private static string FileTextKhac(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"VanKhan\Khac\", fileName);
            return filePath;
        }
        public static string VKLKT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextKhac("VKLKT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string VKLMT()
        {
            string line = "";
            StreamReader streamReader = new StreamReader(FileTextKhac("VKLMT.txt"), Encoding.UTF8);
            line = streamReader.ReadToEnd();
            return line;
        }
        public static string vklkt = "";
        public static string vklmt = "";
        #endregion

        public static void ReadVK()
        {
            #region Văn khấn Tết
            vklgt = VKLGT();
            vklot = VKLOT();
            vkltm = VKLTM();
            vkltnm = VKLTNM();
            vktlm1 = VKTLM1();
            vktn = VKTN();
            vkttm1 = VKTTM1();
            #endregion

            #region Văn khấn khi đi lễ Chùa, Đình, Miếu
            vkbck = VKBCK();
            vkbtqa = VKBTQA();
            vkdo = VKDO();
            vkdth = VKDTH();
            vkdtt = VKDTT();
            vklp = VKLP();
            vkmtn = VKMTN();
            vkth = VKTH();
            vktmlh = VKTMLH();
            #endregion

            #region Văn khấn lễ rằm, mồng 1 & các lễ khác
            vkltmram = VKLTMRam();
            vkm1vs15 = VKM1VS15();
            vkrt7 = VKRT7();
            vkrtg = VKRTG();
            vktdn = VKTDN();
            vktdtt = VKTDTT();
            vktht = VKTHT();
            vkttt = VKTTT();
            #endregion

            #region Văn khấn lễ tang, giỗ tổ tiên
            vkkdtm = VKKDTM();
            vklct = VKLCT();
            vklct49 = VKLCT49();
            vkldt = VKLDT();
            vkncg = VKNCG();
            vkngd = VKNGD();
            vkngh = VKNGH();
            vkngt = VKNGT();
            #endregion

            #region Văn khấn lễ cưới hỏi & sinh con
            vkch = VKCH();
            vkcm = VKCM();
            #endregion

            #region Văn khấn làm nhà, chuyển nhà, tân gia
            vkcnsn = VKCNSN();
            vklnt = VKLNT();
            vkltg = VKLTG();
            #endregion

            #region Các bài văn khấn khác
            vklkt = VKLKT();
            vklmt = VKLMT();
            #endregion
        }
    }
}
