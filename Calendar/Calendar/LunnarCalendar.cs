using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;

namespace LunnarSample
{
    class LunnarCalendar
    {
        #region Chú thích
        // dd mean day
        // mm mean month
        // yy mean year
        // jd mean Julius day
        // timezone mean one of 24 parts that the world is divided into so that different places can set their clocks correctly
        enum Chi { Tý, Sửu, Dần, Mão, Thìn, Tỵ, Ngọ, Mùi, Thân, Dậu, Tuất, Hợi }
        enum Can { Giáp, Ất, Bính, Đinh, Mậu, Kỷ, Canh, Tân, Nhâm, Quý }
        enum Truc { Kiến, Trừ, Mãn, Bình, Định, Chấp, Phá, Nguy, Thành, Thu, Khai, Bế }
        #endregion

        #region Chuyển từ ngày bình thường (dd/mm/yy) sang số ngày Julius
        public static long ChangeDateToJuliusDay(int dd, int mm, int yy)
        {
            var a = (int)(14 - mm) / 12;
            var y = yy + 4800 - a;
            var m = mm + 12 * a - 3;
            var jd = dd + (int)((153 * m + 2) / 5.0f) + (365 * y) + (int)(y / 4.0f) - (int)(y / 100.0f) + (int)(y / 400.0f) - 32045;
            if (jd < 2299161)
            {
                jd = dd + (int)((153 * m + 2) / 5.0f) + 365 * y + (int)(y / 4.0f) - 32083;
            }
            return jd;
        }
        #endregion

        #region Tìm tên thứ của ngày
        public string GetThu(DateTime date)
        {
            long jd = ChangeDateToJuliusDay(date.Day, date.Month, date.Year);
            long ThuNum = (jd + 1) % 7;
            switch (ThuNum)
            {
                case 0:
                    return "Chủ Nhật";
                case 1:
                    return "Thứ Hai";
                case 2:
                    return "Thứ Ba";
                case 3:
                    return "Thứ Tư";
                case 4:
                    return "Thứ Năm";
                case 5:
                    return "Thứ Sáu";
                case 6:
                default:
                    return "Thứ Bảy";
            }
        }
        #endregion

        #region Tìm tên gọi Chi của năm (12 chi)
        public string GetChiNam(int yy)
        {
            return ((Chi)((yy + 8) % 12)).ToString();
        }
        #endregion

        #region Tìm tên gọi Can của năm (10 can)
        public string GetCanNam(int yy)
        {
            return ((Can)((yy + 6) % 10)).ToString();
        }
        #endregion

        #region Tìm tên gọi Chi của tháng (12 chi)
        public string GetChiThang(int LunarMonth) // LunarMonth là tháng Âm lịch được tính trước đó
        {
            int tam = (LunarMonth + 1) % 12; // Tháng 11 là tháng Tý; Tháng 12 là tháng Sửu
            return ((Chi)(tam)).ToString();
        }
        #endregion

        #region Tìm tên gọi Can của tháng (10 can)
        public string GetCanThang(int LunarMonth, int LunarYear)
        {
            int tam = (LunarYear * 12 + LunarMonth + 3) % 10;
            return ((Can)(tam)).ToString();
        }
        #endregion

        #region Tìm tên gọi Chi của ngày (12 chi)
        public string GetChiNgay(DateTime date)
        {
            long jd = ChangeDateToJuliusDay(date.Day, date.Month, date.Year);
            return ((Chi)((jd + 1) % 12)).ToString();
        }
        #endregion

        #region Tìm tên gọi Can của ngày (10 can)
        public string GetCanNgay(DateTime date)
        {
            long jd = ChangeDateToJuliusDay(date.Day, date.Month, date.Year);
            return ((Can)((jd + 9) % 10)).ToString();
        }
        #endregion

        #region Tìm tháng dương lịch từ âm lich
        public int GetSolarMonth(int dd, int mm, int yy)
        {
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(yy, mm, false, dd);
            DateTime date = luni.SolarDate;
            return date.Month;
        }
        #endregion

        #region Lấy thông tin ngày
        public String GetLunnarDayName(DateTime date)
        {
            return GetCanNgay(date) + " " + GetChiNgay(date);
        }
        #endregion

        #region Giờ hoàng đạo
        public String GetZodiacTime(DateTime date)
        {
            String dayChi = GetLunnarDayName(date), saveTmp = "";
            dayChi = dayChi.Substring(dayChi.LastIndexOf(" ")).Trim();

            if (dayChi.Equals("dần", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("thân", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23h -1h),Sửu (1h - 3h),Thìn (7h - 9h),Tỵ (9h - 11h),Mùi (13h - 15h),Tuất (19h - 21h)";
            if (dayChi.Equals("mão", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("dậu", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23h - 1h),Dần (3h - 5h),Mão (5h - 7h),Ngọ (11h - 13h),Mùi (13h - 15h),Dậu (17h - 19h)";
            if (dayChi.Equals("thìn", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("tuất", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3h - 5h),Thìn (7h - 9h),Tỵ (9h - 11h),Thân (15h - 17h),Dậu (17h - 19h),Hợi (21h - 23h)";
            if (dayChi.Equals("tỵ", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("hợi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Sửu (1h - 3h),Thìn (7h - 9h),Ngọ (11h - 13h),Mùi (13h - 15h),Tuất (19h - 21h),Hợi (21h - 23h)";
            if (dayChi.Equals("tý", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("ngọ", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23h - 1h),Sửu (1h - 3h),Mão (5h - 7h),Ngọ (11h - 13h),Thân (15h - 17h),Dậu (17h - 19h)";
            if (dayChi.Equals("sửu", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("mùi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3h - 5h),Mão (5h - 7h),Tỵ (9h - 11h),Thân (15h - 17h),Tuất (19h - 21h),Hợi (21h - 23h)";
            return saveTmp;
        }
        public String GetZodiacTimeSmallVersion(DateTime date)
        {
            String dayChi = GetChiNgay(date);
            String saveTmp = "";

            if (dayChi == "Dần" || dayChi == "Thân")
                saveTmp = "Tý, Sửu, Thìn, Tỵ, Mùi, Tuất";
            if (dayChi == "Mão" || dayChi == "Dậu")
                saveTmp = "Tý, Dần, Mão, Ngọ, Mùi, Dậu";
            if (dayChi == "Thìn" || dayChi == "Tuất")
                saveTmp = "Dần, Thìn, Tỵ, Thân, Dậu, Hợi";
            if (dayChi == "Tỵ" || dayChi == "Hợi")
                saveTmp = "Sửu, Thìn, Ngọ, Mùi, Tuất, Hợi";
            if (dayChi == "Tý" || dayChi == "Ngọ")
                saveTmp = "Tý, Sửu, Mão, Ngọ, Thân, Dậu";
            if (dayChi == "Sửu" || dayChi == "Mùi")
                saveTmp = "Dần, Mão, Tỵ, Thân, Tuất, Hợi";
            return saveTmp;
        }
        #endregion

        #region Giờ hắc đạo
        public String GetUnZodiacTime(DateTime date)
        {
            String dayChi = GetLunnarDayName(date), saveTmp = "";
            dayChi = dayChi.Substring(dayChi.LastIndexOf(" ")).Trim();

            if (dayChi.Equals("dần", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("thân", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3-5), Mão (5-7), Ngọ (11-13), Thân (15-17), Dậu (17-19), Hợi (21-23)";
            if (dayChi.Equals("mão", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("dậu", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Sửu (1-3), Thìn (7-9), Tỵ (9-11), Thân (15-17), Tuất (19-21), Hợi (21-23)";
            if (dayChi.Equals("thìn", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("tuất", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23-1), Sửu (1-3), Mão (5-7), Ngọ (11-13), Mùi (13-15), Tuất (19-21)";
            if (dayChi.Equals("tỵ", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("hợi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23-1), Dần (3-5), Mão (5-7), Tỵ (9-11), Thân (15-17), Dậu (17-19)";
            if (dayChi.Equals("tý", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("ngọ", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3-5), Thìn (7-9), Tỵ (9-11), Mùi (13-15), Tuất (19-21), Hợi (21-23)";
            if (dayChi.Equals("sửu", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("mùi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23-1), Sửu (1-3), Thìn (7-9), Ngọ (11-13), Mùi (13-25), Dậu (17-19)";
            return saveTmp;
        }
        #endregion

        #region Ngày hoàng đạo hay ngày hắc đạo
        // Trả về 1 là ngày hoàng đạo
        // Trả về 0 là ngày bình thường
        // Trả về -1 là ngày hắc đạo
        public int IsZodiacDay(DateTime date, int lunnarmonth)
        {
            string dayChi = GetChiNgay(date);
            if (lunnarmonth == 1 || lunnarmonth == 7)
            {
                if (dayChi == "Tý" || dayChi == "Sửu" || dayChi == "Tỵ" || dayChi == "Mùi")
                    return 1;
                else if (dayChi == "Ngọ" || dayChi == "Mão" || dayChi == "Hợi" || dayChi == "Dậu")
                    return -1;
                else
                    return 0;
            }
            else if (lunnarmonth == 2 || lunnarmonth == 8)
            {
                if (dayChi == "Dần" || dayChi == "Mão" || dayChi == "Mùi" || dayChi == "Dậu")
                    return 1;
                else if (dayChi == "Thân" || dayChi == "Tỵ" || dayChi == "Sửu" || dayChi == "Hợi")
                    return -1;
                else
                    return 0;
            }
            else if (lunnarmonth == 3 || lunnarmonth == 9)
            {
                if (dayChi == "Thìn" || dayChi == "Tỵ" || dayChi == "Dậu" || dayChi == "Hợi")
                    return 1;
                else if (dayChi == "Tuất" || dayChi == "Mão" || dayChi == "Mùi" || dayChi == "Sửu")
                    return -1;
                else
                    return 0;
            }
            else if (lunnarmonth == 4 || lunnarmonth == 10)
            {
                if (dayChi == "Ngọ" || dayChi == "Mùi" || dayChi == "Sửu" || dayChi == "Hợi")
                    return 1;
                else if (dayChi == "Tý" || dayChi == "Mão" || dayChi == "Tỵ" || dayChi == "Dậu")
                    return -1;
                else
                    return 0;
            }
            else if (lunnarmonth == 5 || lunnarmonth == 11)
            {
                if (dayChi == "Thân" || dayChi == "Sửu" || dayChi == "Dậu" || dayChi == "Mão")
                    return 1;
                else if (dayChi == "Dần" || dayChi == "Hợi" || dayChi == "Mùi" || dayChi == "Tỵ")
                    return -1;
                else
                    return 0;
            }
            else
            {
                if (dayChi == "Tuất" || dayChi == "Hợi" || dayChi == "Tỵ" || dayChi == "Mão")
                    return 1;
                else if (dayChi == "Thìn" || dayChi == "Sửu" || dayChi == "Mùi" || dayChi == "Dậu")
                    return -1;
                else
                    return 0;
            }
        }
        #endregion

        #region Tìm trực âm lịch
        public string GoodDayString(DateTime date)
        {
            string s = "";
            LuniSolarDate<VietnameseLocalInfoProvider> lunardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            switch (GetChiThang(lunardate.Month))
            {
                case "Tý":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Kiến.ToString();
                        case "Sửu":
                            return Truc.Trừ.ToString();
                        case "Dần":
                            return Truc.Mãn.ToString();
                        case "Mão":
                            return Truc.Bình.ToString();
                        case "Thìn":
                            return Truc.Định.ToString();
                        case "Tỵ":
                            return Truc.Chấp.ToString();
                        case "Ngọ":
                            return Truc.Phá.ToString();
                        case "Mùi":
                            return Truc.Nguy.ToString();
                        case "Thân":
                            return Truc.Thành.ToString();
                        case "Dậu":
                            return Truc.Thu.ToString();
                        case "Tuất":
                            return Truc.Khai.ToString();
                        case "Hợi":
                            return Truc.Bế.ToString();
                        default:
                            return s;
                    }
                case "Sửu":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Bế.ToString();
                        case "Sửu":
                            return Truc.Kiến.ToString();
                        case "Dần":
                            return Truc.Trừ.ToString();
                        case "Mão":
                            return Truc.Mãn.ToString();
                        case "Thìn":
                            return Truc.Bình.ToString();
                        case "Tỵ":
                            return Truc.Định.ToString();
                        case "Ngọ":
                            return Truc.Chấp.ToString();
                        case "Mùi":
                            return Truc.Phá.ToString();
                        case "Thân":
                            return Truc.Nguy.ToString();
                        case "Dậu":
                            return Truc.Thành.ToString();
                        case "Tuất":
                            return Truc.Thu.ToString();
                        case "Hợi":
                            return Truc.Khai.ToString();
                        default:
                            return s;
                    }
                case "Dần":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Khai.ToString();
                        case "Sửu":
                            return Truc.Bế.ToString();
                        case "Dần":
                            return Truc.Kiến.ToString();
                        case "Mão":
                            return Truc.Trừ.ToString();
                        case "Thìn":
                            return Truc.Mãn.ToString();
                        case "Tỵ":
                            return Truc.Bình.ToString();
                        case "Ngọ":
                            return Truc.Định.ToString();
                        case "Mùi":
                            return Truc.Chấp.ToString();
                        case "Thân":
                            return Truc.Phá.ToString();
                        case "Dậu":
                            return Truc.Nguy.ToString();
                        case "Tuất":
                            return Truc.Thành.ToString();
                        case "Hợi":
                            return Truc.Thu.ToString();
                        default:
                            return s;
                    }
                case "Mão":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Thu.ToString();
                        case "Sửu":
                            return Truc.Khai.ToString();
                        case "Dần":
                            return Truc.Bế.ToString();
                        case "Mão":
                            return Truc.Kiến.ToString();
                        case "Thìn":
                            return Truc.Trừ.ToString();
                        case "Tỵ":
                            return Truc.Mãn.ToString();
                        case "Ngọ":
                            return Truc.Bình.ToString();
                        case "Mùi":
                            return Truc.Định.ToString();
                        case "Thân":
                            return Truc.Chấp.ToString();
                        case "Dậu":
                            return Truc.Phá.ToString();
                        case "Tuất":
                            return Truc.Nguy.ToString();
                        case "Hợi":
                            return Truc.Thành.ToString();
                        default:
                            return s;
                    }
                case "Thìn":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Thành.ToString();
                        case "Sửu":
                            return Truc.Thu.ToString();
                        case "Dần":
                            return Truc.Khai.ToString();
                        case "Mão":
                            return Truc.Bế.ToString();
                        case "Thìn":
                            return Truc.Kiến.ToString();
                        case "Tỵ":
                            return Truc.Trừ.ToString();
                        case "Ngọ":
                            return Truc.Mãn.ToString();
                        case "Mùi":
                            return Truc.Bình.ToString();
                        case "Thân":
                            return Truc.Định.ToString();
                        case "Dậu":
                            return Truc.Chấp.ToString();
                        case "Tuất":
                            return Truc.Phá.ToString();
                        case "Hợi":
                            return Truc.Nguy.ToString();
                        default:
                            return s;
                    }
                case "Tỵ":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Nguy.ToString();
                        case "Sửu":
                            return Truc.Thành.ToString();
                        case "Dần":
                            return Truc.Thu.ToString();
                        case "Mão":
                            return Truc.Khai.ToString();
                        case "Thìn":
                            return Truc.Bế.ToString();
                        case "Tỵ":
                            return Truc.Kiến.ToString();
                        case "Ngọ":
                            return Truc.Trừ.ToString();
                        case "Mùi":
                            return Truc.Mãn.ToString();
                        case "Thân":
                            return Truc.Bình.ToString();
                        case "Dậu":
                            return Truc.Định.ToString();
                        case "Tuất":
                            return Truc.Chấp.ToString();
                        case "Hợi":
                            return Truc.Phá.ToString();
                        default:
                            return s;
                    }
                case "Ngọ":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Phá.ToString();
                        case "Sửu":
                            return Truc.Nguy.ToString();
                        case "Dần":
                            return Truc.Thành.ToString();
                        case "Mão":
                            return Truc.Thu.ToString();
                        case "Thìn":
                            return Truc.Khai.ToString();
                        case "Tỵ":
                            return Truc.Bế.ToString();
                        case "Ngọ":
                            return Truc.Kiến.ToString();
                        case "Mùi":
                            return Truc.Trừ.ToString();
                        case "Thân":
                            return Truc.Mãn.ToString();
                        case "Dậu":
                            return Truc.Bình.ToString();
                        case "Tuất":
                            return Truc.Định.ToString();
                        case "Hợi":
                            return Truc.Chấp.ToString();
                        default:
                            return s;
                    }
                case "Mùi":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Chấp.ToString();
                        case "Sửu":
                            return Truc.Phá.ToString();
                        case "Dần":
                            return Truc.Nguy.ToString();
                        case "Mão":
                            return Truc.Thành.ToString();
                        case "Thìn":
                            return Truc.Thu.ToString();
                        case "Tỵ":
                            return Truc.Khai.ToString();
                        case "Ngọ":
                            return Truc.Bế.ToString();
                        case "Mùi":
                            return Truc.Kiến.ToString();
                        case "Thân":
                            return Truc.Trừ.ToString();
                        case "Dậu":
                            return Truc.Mãn.ToString();
                        case "Tuất":
                            return Truc.Bình.ToString();
                        case "Hợi":
                            return Truc.Định.ToString();
                        default:
                            return s;
                    }
                case "Thân":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Định.ToString();
                        case "Sửu":
                            return Truc.Chấp.ToString();
                        case "Dần":
                            return Truc.Phá.ToString();
                        case "Mão":
                            return Truc.Nguy.ToString();
                        case "Thìn":
                            return Truc.Thành.ToString();
                        case "Tỵ":
                            return Truc.Thu.ToString();
                        case "Ngọ":
                            return Truc.Khai.ToString();
                        case "Mùi":
                            return Truc.Bế.ToString();
                        case "Thân":
                            return Truc.Kiến.ToString();
                        case "Dậu":
                            return Truc.Trừ.ToString();
                        case "Tuất":
                            return Truc.Mãn.ToString();
                        case "Hợi":
                            return Truc.Bình.ToString();
                        default:
                            return s;
                    }
                case "Dậu":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Bình.ToString();
                        case "Sửu":
                            return Truc.Định.ToString();
                        case "Dần":
                            return Truc.Chấp.ToString();
                        case "Mão":
                            return Truc.Phá.ToString();
                        case "Thìn":
                            return Truc.Nguy.ToString();
                        case "Tỵ":
                            return Truc.Thành.ToString();
                        case "Ngọ":
                            return Truc.Thu.ToString();
                        case "Mùi":
                            return Truc.Khai.ToString();
                        case "Thân":
                            return Truc.Bế.ToString();
                        case "Dậu":
                            return Truc.Kiến.ToString();
                        case "Tuất":
                            return Truc.Trừ.ToString();
                        case "Hợi":
                            return Truc.Mãn.ToString();
                        default:
                            return s;
                    }
                case "Tuất":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Mãn.ToString();
                        case "Sửu":
                            return Truc.Bình.ToString();
                        case "Dần":
                            return Truc.Định.ToString();
                        case "Mão":
                            return Truc.Chấp.ToString();
                        case "Thìn":
                            return Truc.Phá.ToString();
                        case "Tỵ":
                            return Truc.Nguy.ToString();
                        case "Ngọ":
                            return Truc.Thành.ToString();
                        case "Mùi":
                            return Truc.Thu.ToString();
                        case "Thân":
                            return Truc.Khai.ToString();
                        case "Dậu":
                            return Truc.Bế.ToString();
                        case "Tuất":
                            return Truc.Kiến.ToString();
                        case "Hợi":
                            return Truc.Trừ.ToString();
                        default:
                            return s;
                    }
                case "Hợi":
                    switch (GetChiNgay(date))
                    {
                        case "Tý":
                            return Truc.Trừ.ToString();
                        case "Sửu":
                            return Truc.Mãn.ToString();
                        case "Dần":
                            return Truc.Bình.ToString();
                        case "Mão":
                            return Truc.Định.ToString();
                        case "Thìn":
                            return Truc.Chấp.ToString();
                        case "Tỵ":
                            return Truc.Phá.ToString();
                        case "Ngọ":
                            return Truc.Nguy.ToString();
                        case "Mùi":
                            return Truc.Thành.ToString();
                        case "Thân":
                            return Truc.Thu.ToString();
                        case "Dậu":
                            return Truc.Khai.ToString();
                        case "Tuất":
                            return Truc.Bế.ToString();
                        case "Hợi":
                            return Truc.Kiến.ToString();
                        default:
                            return s;
                    }
                default:
                    return s;
            }
        }
        #endregion

        #region Danh sách trực âm lịch
        public static DataTable DetailTruc()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            #region Tạo bảng

            //Tạo cột tên
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột việc nên làm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Do";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột việc không nên làm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UnDo";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột thông tin thêm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Bonus";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #endregion

            #region Thêm dữ liệu vào bảng

            #region Kiến
            row = dt.NewRow();
            row["Name"] = string.Format("Kiến");
            row["Do"] = string.Format("Tốt cho các việc thi ơn huệ, trồng cây cối.");
            row["UnDo"] = string.Format("Xấu cho các việc chôn cất, đào giếng, lợp nhà.");
            row["Bonus"] = string.Format("Người sinh vào ngày trực Kiến khô khan, gian nan lập thân, hay gặp sóng gió, mặc dù là người mạnh mẽ, độc lập, nhưng không mấy gặp may.");
            dt.Rows.Add(row);
            #endregion

            #region Trừ
            row = dt.NewRow();
            row["Name"] = string.Format("Trừ");
            row["Do"] = string.Format("Tốt cho các việc trừ phục, cúng giải, cạo đầu.");
            row["UnDo"] = string.Format("Xấu cho các việc xuất vốn, hội họp, châm chích.");
            row["Bonus"] = string.Format("Người sinh vào trực này thật thà, số không được nhờ bà con, không có bạn tốt, số phận lao đao, đàn ông còn được vinh hoa, đàn bà khó nuôi con.");
            dt.Rows.Add(row);
            #endregion

            #region Mãn
            row = dt.NewRow();
            row["Name"] = string.Format("Mãn");
            row["Do"] = string.Format("Tốt cho các việc xuất hành, sửa kho, dựng nhà, mở tiệm.");
            row["UnDo"] = string.Format("Xấu cho các việc chôn cất, thưa kiện, xuất vốn, nhậm chức.");
            row["Bonus"] = string.Format("Người sinh vào trực này khôn ngoan, trí tuệ. Con cái dễ nuôi, bạn bè tốt. Phúc đức nhiều.");
            dt.Rows.Add(row);
            #endregion

            #region Bình
            row = dt.NewRow();
            row["Name"] = string.Format("Bình");
            row["Do"] = string.Format("Tốt cho các việc rời bếp, thượng lương, làm chuồng lục súc.");
            row["UnDo"] = string.Format("Xấu cho các việc khai trương, xuất nhập tài vật, giá thú, động thổ.");
            row["Bonus"] = string.Format("Người sinh vào trực này thông minh, kín đáo. Khéo léo giao thiệp người ngoài quý mến.");
            dt.Rows.Add(row);
            #endregion

            #region Định
            row = dt.NewRow();
            row["Name"] = string.Format("Định");
            row["Do"] = string.Format("Tốt cho các việc giao dịch, buôn bán, làm chuồng lục súc, thi ơn huệ.");
            row["UnDo"] = string.Format("Xấu cho các việc xuất hành, thưa kiện, châm chích, an sàng.");
            row["Bonus"] = string.Format("Người sinh vào trực này nết na, được hưởng lộc của mẹ cha. Nhân từ, đức hạnh. Thanh liêm - Ôn hòa - Nhân duyên tự mình kén lấy.");
            dt.Rows.Add(row);
            #endregion

            #region Chấp
            row = dt.NewRow();
            row["Name"] = string.Format("Chấp");
            row["Do"] = string.Format("Tốt cho các việc tạo tác, sửa giếng, thu người làm.");
            row["UnDo"] = string.Format("Xấu cho các việc xuất nhập vốn liếng, khai kho, an sàng.");
            row["Bonus"] = string.Format("Người sinh vào trực này nóng tính - Đàn ông rộng rãi - Đàn bà hẹp hòi.");
            dt.Rows.Add(row);
            #endregion

            #region Phá
            row = dt.NewRow();
            row["Name"] = string.Format("Phá");
            row["Do"] = string.Format("Tốt cho các việc dỡ nhà, phá vách, ra đi.");
            row["UnDo"] = string.Format("Xấu cho các việc mở cửa hàng, may mặc, sửa kho, hội họp.");
            row["Bonus"] = string.Format("Người sinh vào trực này lao đao, lo âu phải tha phương cầu thực. Nhưng vẫn có thể làm nên sự nghiệp bất ngờ.");
            dt.Rows.Add(row);
            #endregion

            #region Nguy
            row = dt.NewRow();
            row["Name"] = string.Format("Nguy");
            row["Do"] = string.Format("Tốt cho các việc cúng lễ, may mặc, từ tụng.");
            row["UnDo"] = string.Format("Xấu cho các việc hội họp, châm chích, giá thú, làm chuồng lục súc, khai trương.");
            row["Bonus"] = string.Format("Người sinh vào trực này nhiều lo nghĩ - phải Bắc Nam bôn tẩu. Đàn bà tốt, đàn ông kém.");
            dt.Rows.Add(row);
            #endregion

            #region Thành
            row = dt.NewRow();
            row["Name"] = string.Format("Thành");
            row["Do"] = string.Format("Tốt cho các việc nhập học, giá thú, may mặc, thượng lương.");
            row["UnDo"] = string.Format("Xấu cho các việc kiện tụng, mai táng, châm chích, di cư.");
            row["Bonus"] = string.Format("Người sinh vào trực này yên vui - giàu sang - đàn ông lịch sự - đàn bà buồn vui thất thường.");
            dt.Rows.Add(row);
            #endregion

            #region Thu
            row = dt.NewRow();
            row["Name"] = string.Format("Thu");
            row["Do"] = string.Format("Tốt cho các việc khai trương, lập kho vựa, giao dịch, may mặc.");
            row["UnDo"] = string.Format("Xấu cho các việc an táng, giá thú, nhậm chức, xuất nhập tài vật.");
            row["Bonus"] = string.Format("Người sinh vào trực này long đong vất vả. Phải dựa vào người khác phái.");
            dt.Rows.Add(row);
            #endregion

            #region Khai
            row = dt.NewRow();
            row["Name"] = string.Format("Khai");
            row["Do"] = string.Format("Tốt cho các việc làm nhà, động thổ, làm chuồng gia súc, giá thú, đào giếng.");
            row["UnDo"] = string.Format("Xấu cho các việc giao dịch, châm chích, trồng tỉa.");
            row["Bonus"] = string.Format("Người sinh vào trực này long đong tứ bề - đàn ông vui vẻ. Đàn bà hay gây lộn với chồng.");
            dt.Rows.Add(row);
            #endregion

            #region Bế
            row = dt.NewRow();
            row["Name"] = string.Format("Bế");
            row["Do"] = string.Format("Tốt cho các việc làm cửa, thượng lương, giá thú, trị bệnh.");
            row["UnDo"] = string.Format("Xấu cho các việc nhậm chức, châm chích, đào giếng, kiện thưa.");
            row["Bonus"] = string.Format("Người sinh vào trực này học rộng hiểu cao, thông minh, thành đạt khoa cử.");
            dt.Rows.Add(row);
            #endregion

            #endregion

            return dt;

        }
        #endregion

        #region Tìm thông tin chi tiết của trực
        public DataTable GetDetailTruc(DateTime date)
        {
            string s = GoodDayString(date);
            DataTable gdt = DetailTruc();
            DataTable dt = new DataTable();
            DataColumn column;

            #region Tạo bảng

            //Tạo cột việc nên làm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Do";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột việc không nên làm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UnDo";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột thông tin thêm
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Bonus";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #endregion

            foreach (DataRow row in gdt.Rows)
            {
                string word = (string)row["Name"];

                if(word == s)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["Do"] = row["Do"];
                    dataRow["UnDo"] = row["UnDo"];
                    dataRow["Bonus"] = row["Bonus"];
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }
        #endregion

        #region Tìm thông tin các tiết khí
        public string SolarTermString(string s)
        {
            switch (s)
            {
                case "Lập Xuân":
                    return string.Format("{0} (Từ ngày 4/2 đến 18/2)", s);
                case "Vũ Thủy":
                    return string.Format("{0} (Từ ngày 19/2 đến 4/3)", s);
                case "Kinh Trập":
                    return string.Format("{0} (Từ ngày 5/3 đến 20/3)", s);
                case "Xuân Phân":
                    return string.Format("{0} (Từ ngày 20/3 đến 4/4)", s);
                case "Thanh Minh":
                    return string.Format("{0} (Từ ngày 5/4 đến 19/4)", s);
                case "Cốc Vũ":
                    return string.Format("{0} (Từ ngày 20/4 đến 5/5)", s);
                case "Lập Hạ":
                    return string.Format("{0} (Từ ngày 6/5 đến 20/5)", s);
                case "Tiểu Mãn":
                    return string.Format("{0} (Từ ngày 21/5 đến 5/6)", s);
                case "Mang Chủng":
                    return string.Format("{0} (Từ ngày 6/6 đến 20/6)", s);
                case "Hạ Chí":
                    return string.Format("{0} (Từ ngày 21/6 đến 6/7)", s);
                case "Tiểu Thử":
                    return string.Format("{0} (Từ ngày 7/7 đến 22/7)", s);
                case "Đại Thử":
                    return string.Format("{0} (Từ ngày 23/7 đến 6/8)", s);
                case "Lập Thu":
                    return string.Format("{0} (Từ ngày 7/8 đến 22/8)", s);
                case "Xử Thử":
                    return string.Format("{0} (Từ ngày 23/8 đến 7/9)", s);
                case "Bạch Lộ":
                    return string.Format("{0} (Từ ngày 8/9 đến 22/9)", s);
                case "Thu Phân":
                    return string.Format("{0} (Từ ngày 23/9 đến 7/10)", s);
                case "Hàn Lộ":
                    return string.Format("{0} (Từ ngày 8/10 đến 22/10)", s);
                case "Sương Giáng":
                    return string.Format("{0} (Từ ngày 23/10 đến 6/11)", s);
                case "Lập Đông":
                    return string.Format("{0} (Từ ngày 7/11 đến 21/11)", s);
                case "Tiểu Tuyết":
                    return string.Format("{0} (Từ ngày 22/11 đến 6/12)", s);
                case "Đại Tuyết":
                    return string.Format("{0} (Từ ngày 7/12 đến 21/12)", s);
                case "Đông Chí":
                    return string.Format("{0} (Từ ngày 22/12 đến 5/1)", s);
                case "Tiểu Hàn":
                    return string.Format("{0} (Từ ngày 6/1 đến 20/1)", s);
                case "Đại Hàn":
                    return string.Format("{0} (Từ ngày 21/1 đến 3/2)", s);
                default:
                    return "";

            }
        }
        #endregion

        #region Tìm giờ âm
        public string GetGioAm(int hour)
        {
            switch (hour)
            {
                case 23:
                case 0:
                    return "Tý";
                case 1:
                case 2:
                    return "Sửu";
                case 3:
                case 4:
                    return "Dần";
                case 5:
                case 6:
                    return "Mão";
                case 7:
                case 8:
                    return "Thìn";
                case 9:
                case 10:
                    return "Tỵ";
                case 11:
                case 12:
                    return "Ngọ";
                case 13:
                case 14:
                    return "Mùi";
                case 15:
                case 16:
                    return "Thân";
                case 17:
                case 18:
                    return "Dậu";
                case 19:
                case 20:
                    return "Tuất";
                case 21:
                case 22:
                    return "Hơi";
                default:
                    return "";
            }
        }
        #endregion

        #region Tìm Hỷ Thần
        public string GetHyThan(DateTime date)
        {
            string s = "";
            string sCan = GetCanNgay(date);
            switch (sCan)
            {
                case "Giáp":
                    s = "Đông Bắc";
                    break;
                case "Ất":
                    s = "Tây Bắc";
                    break;
                case "Bính":
                    s = "Tây Nam";
                    break;
                case "Đinh":
                    s = "chính Nam";
                    break;
                case "Mậu":
                    s = "Đông Nam";
                    break;
                case "Kỷ":
                    s = "Đông Bắc";
                    break;
                case "Canh":
                    s = "Tây Bắc";
                    break;
                case "Tân":
                    s = "Tây Nam";
                    break;
                case "Nhâm":
                    s = "chính Nam";
                    break;
                case "Quý":
                    s = "Đông Nam";
                    break;
                default:
                    break;
            }

            return s;
        }
        #endregion

        #region Tìm Tài Thần
        public string GetTaiThan(DateTime date)
        {
            string s = "";
            string sCan = GetCanNgay(date);
            switch (sCan)
            {
                case "Giáp":
                    s = "Đông Nam";
                    break;
                case "Ất":
                    s = "Đông Nam";
                    break;
                case "Bính":
                    s = "Đông";
                    break;
                case "Đinh":
                    s = "Đông";
                    break;
                case "Mậu":
                    s = "Bắc";
                    break;
                case "Kỷ":
                    s = "Nam";
                    break;
                case "Canh":
                    s = "Tây Nam";
                    break;
                case "Tân":
                    s = "Tây Nam";
                    break;
                case "Nhâm":
                    s = "Tây";
                    break;
                case "Quý":
                    s = "Tây Bắc";
                    break;
                default:
                    break;
            }

            return s;
        }
        #endregion

        #region Tìm Hạc Thần
        public string GetHacThan(DateTime date)
        {
            string s = "";
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            string sday = luni.DayName;
            switch (sday)
            {
                case "Kỷ Dậu":
                case "Canh Tuất":
                case "Tân Hợi":
                case "Nhâm Tý":
                case "Quý Sửu":
                case "Giáp Dần":
                    s = "Đông Bắc";
                    break;
                case "Ất Mão":
                case "Bính Thìn":
                case "Đinh Tỵ":
                case "Mậu Ngọ":
                case "Kỷ Mùi":
                    s = "Đông";
                    break;
                case "Canh Thân":
                case "Tân Dậu":
                case "Nhâm Tuất":
                case "Quý Hợi":
                case "Giáp Tý":
                case "Ất Sửu":
                    s = "Đông Nam";
                    break;
                case "Bính Dần":
                case "Đinh Mão":
                case "Mậu Thìn":
                case "Kỷ Tỵ":
                case "Canh Ngọ":
                    s = "Nam";
                    break;
                case "Tân Mùi":
                case "Nhâm Thân":
                case "Quý Dậu":
                case "Giáp Tuất":
                case "Ất Hợi":
                case "Bính Tý":
                    s = "Tây Nam";
                    break;
                case "Đinh Sửu":
                case "Mậu Dần":
                case "Kỷ Mão":
                case "Canh Thìn":
                case "Tân Tỵ":
                    s = "Tây";
                    break;
                case "Nhâm Ngọ":
                case "Quý Mùi":
                case "Giáp Thân":
                case "Ất Dậu":
                case "Bính Tuất":
                case "Đinh Hợi":
                    s = "Tây Bắc";
                    break;
                case "Mậu Tý":
                case "Kỷ Sửu":
                case "Canh Dần":
                case "Tân Mão":
                case "Nhâm Thìn":
                    s = "Bắc";
                    break;
                default:
                    s = "Vô";
                    break;
            }

            return s;
        }
        #endregion

        #region Danh sách sao tốt, sao xấu
        public static DataTable GoodStar()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            #region Tạo bảng

            //Tạo cột tên sao
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột nội dung
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo số giá trị trong mỗi tháng
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Num";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #region Tạo cột tháng

            //Tháng 1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "1";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "2";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 3
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "3";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 4
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "4";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 5
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "5";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 6
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "6";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 7
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "7";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 8
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "8";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 9
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "9";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 10
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "10";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 11
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "11";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 12
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "12";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #endregion

            #endregion

            #region Thêm dữ liệu vào bảng

            #region Thiên Đức
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Đức");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Đinh");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Nhâm");
            row["4"] = string.Format("Tân");
            row["5"] = string.Format("Hợi");
            row["6"] = string.Format("Giáp");
            row["7"] = string.Format("Quý");
            row["8"] = string.Format("Dần");
            row["9"] = string.Format("Bính");
            row["10"] = string.Format("Ất");
            row["11"] = string.Format("Tỵ");
            row["12"] = string.Format("Canh");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Đức Hợp
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Đức Hợp");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Nhâm");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Đinh");
            row["4"] = string.Format("Bính");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Kỷ");
            row["7"] = string.Format("Mậu");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tân");
            row["10"] = string.Format("Canh");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Ất");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Đức
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Đức");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Bính");
            row["2"] = string.Format("Giáp");
            row["3"] = string.Format("Nhâm");
            row["4"] = string.Format("Canh");
            row["5"] = string.Format("Bính");
            row["6"] = string.Format("Giáp");
            row["7"] = string.Format("Nhâm");
            row["8"] = string.Format("Canh");
            row["9"] = string.Format("Bính");
            row["10"] = string.Format("Giáp");
            row["11"] = string.Format("Nhâm");
            row["12"] = string.Format("Canh");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Đức Hợp
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Đức Hợp");
            row["Mean"] = string.Format("Tốt mọi việc, kỵ tố tụng");
            row["Num"] = 1;
            row["1"] = string.Format("Tân");
            row["2"] = string.Format("Kỷ");
            row["3"] = string.Format("Đinh");
            row["4"] = string.Format("Ất");
            row["5"] = string.Format("Tân");
            row["6"] = string.Format("Kỷ");
            row["7"] = string.Format("Đinh");
            row["8"] = string.Format("Ất");
            row["9"] = string.Format("Tân");
            row["10"] = string.Format("Kỷ");
            row["11"] = string.Format("Đinh");
            row["12"] = string.Format("Ất");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Hỷ
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Hỷ (Trực Thành)");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là hôn thú");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Hợi");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Sửu");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Mùi");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Phú
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Phú (Trực Mãn)");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là xây dựng nhà cửa, khai trương và an táng");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Phúc
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Phúc");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 2;
            row["1"] = string.Format("Kỷ/");
            row["2"] = string.Format("Mậu/");
            row["3"] = string.Format("/");
            row["4"] = string.Format("Tân/Quý");
            row["5"] = string.Format("Tân/Nhâm");
            row["6"] = string.Format("/");
            row["7"] = string.Format("Ất/");
            row["8"] = string.Format("Giáp/");
            row["9"] = string.Format("/");
            row["10"] = string.Format("Đinh/");
            row["11"] = string.Format("Bính/");
            row["12"] = string.Format("/");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Quý
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Quý");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 2;
            row["1"] = string.Format("Giáp/Ất");
            row["2"] = string.Format("Giáp/Ất");
            row["3"] = string.Format("Giáp/Ất");
            row["4"] = string.Format("Bính/Đinh");
            row["5"] = string.Format("Bính/Đinh");
            row["6"] = string.Format("Bính/Đinh");
            row["7"] = string.Format("Canh/Tân");
            row["8"] = string.Format("Canh/Tân");
            row["9"] = string.Format("Canh/Tân");
            row["10"] = string.Format("Nhâm/Quý");
            row["11"] = string.Format("Nhâm/Quý");
            row["12"] = string.Format("Nhâm/Quý");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Xá
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Xá");
            row["Mean"] = string.Format("Tốt cho tế tự, giải oan, trừ được các sao xấu, chỉ kiêng kỵ động thổ.Nếu gặp trực khai thì rất tốt tức là ngày thiên xá gặp sinh khí");
            row["Num"] = 3;
            row["1"] = string.Format("Mậu Dần");
            row["2"] = string.Format("Mậu Dần");
            row["3"] = string.Format("Mậu Dần");
            row["4"] = string.Format("Giáp Ngọ");
            row["5"] = string.Format("");
            row["6"] = string.Format("Giáp Ngọ");
            row["7"] = string.Format("Mậu Thân");
            row["8"] = string.Format("Mậu Thân");
            row["9"] = string.Format("Mậu Thân");
            row["10"] = string.Format("Giáp Tý");
            row["11"] = string.Format("");
            row["12"] = string.Format("Giáp Tý");
            dt.Rows.Add(row);
            #endregion

            #region Sinh Khí 
            row = dt.NewRow();
            row["Name"] = string.Format("Sinh Khí (Trực Khai)");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là làm nhà, sửa nhà, động thổ, trồng cây");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Sửu");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Thìn");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Thân");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Tuất");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Thành 
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Thành (Ngọc Đường Hoàng Đạo)");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Mùi");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Sửu");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Quan
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Quan (trùng với tư mệnh Hoàng Đạo)");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Thìn");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Thân");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Mã
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Mã (Lộc Mã trùng với Bạch Hổ (xấu))");
            row["Mean"] = string.Format("Tốt cho việc xuất hành, giao dịch, cầu tài lộc");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Tý");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Tài
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Tài (trùng ngày Kim Quỹ Hoàng Đạo)");
            row["Mean"] = string.Format("Tốt cho việc cầu tài lộc, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Thân");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Dần");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Thân");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Dý");
            row["12"] = string.Format("Dần");
            dt.Rows.Add(row);
            #endregion

            #region Địa Tài
            row = dt.NewRow();
            row["Name"] = string.Format("Địa Tài (trùng ngày Bảo Quang Hoàng Đạo)");
            row["Mean"] = string.Format("Tốt cho việc cầu tài lộc, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Dậu");
            row["4"] = string.Format("Hợi");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Tài
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Tài");
            row["Mean"] = string.Format("Tốt cho việc cầu tài lộc, khai trương, xuất hành, di chuyển giao dịch");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Mùi");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Ân
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Ân");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Bính");
            row["2"] = string.Format("Đinh");
            row["3"] = string.Format("Canh");
            row["4"] = string.Format("Kỷ");
            row["5"] = string.Format("Mậu");
            row["6"] = string.Format("Tân");
            row["7"] = string.Format("Nhâm");
            row["8"] = string.Format("Quý");
            row["9"] = string.Format("Canh");
            row["10"] = string.Format("Ất");
            row["11"] = string.Format("Giáp");
            row["12"] = string.Format("Tân");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Không
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Không");
            row["Mean"] = string.Format("Tốt cho việc làm nhà, làm vườn");
            row["Num"] = 1;
            row["1"] = string.Format("Nhâm");
            row["2"] = string.Format("Canh");
            row["3"] = string.Format("Bính");
            row["4"] = string.Format("Giáp");
            row["5"] = string.Format("Nhâm");
            row["6"] = string.Format("Canh");
            row["7"] = string.Format("Bính");
            row["8"] = string.Format("Giáp");
            row["9"] = string.Format("Nhâm");
            row["10"] = string.Format("Canh");
            row["11"] = string.Format("Bính");
            row["12"] = string.Format("Giáp");
            dt.Rows.Add(row);
            #endregion

            #region Minh Tinh
            row = dt.NewRow();
            row["Name"] = string.Format("Minh Tinh (trùng với Thiên Lao Hắc Đạo (xấu))");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Thân");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Thìn");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Thân");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Thìn");
            row["12"] = string.Format("Ngọ");
            dt.Rows.Add(row);
            #endregion

            #region Thánh Tâm
            row = dt.NewRow();
            row["Name"] = string.Format("Thánh Tâm");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là cầu phúc, tế tự");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Ngọ");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Dần");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Mão");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Thìn");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Ngũ Phú
            row = dt.NewRow();
            row["Name"] = string.Format("Ngũ Phú");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Hợi");
            row["6"] = string.Format("Dần");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Tỵ");
            row["12"] = string.Format("Thân");
            dt.Rows.Add(row);
            #endregion

            #region Lộc Khố
            row = dt.NewRow();
            row["Name"] = string.Format("Lộc Khố");
            row["Mean"] = string.Format("Tốt cho việc cầu tài, khai trương, giao dịch");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Phúc Sinh
            row = dt.NewRow();
            row["Name"] = string.Format("Phúc Sinh");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Cát Khánh
            row = dt.NewRow();
            row["Name"] = string.Format("Cát Khánh");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Dậu");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Thìn");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Mão");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Âm Đức
            row = dt.NewRow();
            row["Name"] = string.Format("Âm Đức");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Dậu");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region U Vi Tinh
            row = dt.NewRow();
            row["Name"] = string.Format("U Vi Tinh");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Ngọ");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Dần");
            dt.Rows.Add(row);
            #endregion

            #region Mãn Đức Tinh
            row = dt.NewRow();
            row["Name"] = string.Format("Mãn Đức Tinh");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Thân");
            row["8"] = string.Format("Sửu");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #region Kính Tâm
            row = dt.NewRow();
            row["Name"] = string.Format("Kính Tâm");
            row["Mean"] = string.Format("Tốt đối với tang lễ");
            row["Num"] = 1;
            row["1"] = string.Format("Mùi");
            row["2"] = string.Format("Sửu");
            row["3"] = string.Format("Thân");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Thìn");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Tỵ");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Ngọ");
            dt.Rows.Add(row);
            #endregion

            #region Tuế Hợp
            row = dt.NewRow();
            row["Name"] = string.Format("Tuế Hợp");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Dần");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Giải
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Giải");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Thân");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Dậu");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Tuất");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Quan Nhật
            row = dt.NewRow();
            row["Name"] = string.Format("Quan Nhật");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("");
            row["4"] = string.Format("");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("");
            row["7"] = string.Format("");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("");
            row["10"] = string.Format("");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("");
            dt.Rows.Add(row);
            #endregion

            #region Hoạt Điệu
            row = dt.NewRow();
            row["Name"] = string.Format("Hoạt Điệu");
            row["Mean"] = string.Format("Tốt, nhưng gặp thụ tử thì xấu");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Tý");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Dần");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Thìn");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Thân");
            dt.Rows.Add(row);
            #endregion

            #region Giải Thần
            row = dt.NewRow();
            row["Name"] = string.Format("Giải Thần");
            row["Mean"] = string.Format("Tốt cho việc tế tự, tố tụng, giải oan (trừ được các sao xấu)");
            row["Num"] = 1;
            row["1"] = string.Format("Thân");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Dần");
            row["8"] = string.Format("Dần");
            row["9"] = string.Format("Thìn");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Ngọ");
            dt.Rows.Add(row);
            #endregion

            #region Phổ Hộ
            row = dt.NewRow();
            row["Name"] = string.Format("Phổ Hộ (Hội Hộ)");
            row["Mean"] = string.Format("Tốt mọi việc, làm phúc, giá thú, xuất hành");
            row["Num"] = 1;
            row["1"] = string.Format("Thân");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Dậu");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Tuất");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Ích Hậu
            row = dt.NewRow();
            row["Name"] = string.Format("Ích Hậu");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Mão");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Thìn");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Tỵ");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Tục Thế
            row = dt.NewRow();
            row["Name"] = string.Format("Tục Thế");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Yếu Yên
            row = dt.NewRow();
            row["Name"] = string.Format("Yếu Yên (Thiên Quý)");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Mão");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Thìn");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Dịch Mã
            row = dt.NewRow();
            row["Name"] = string.Format("Dịch Mã");
            row["Mean"] = string.Format("Tốt mọi việc, nhất là xuất hành");
            row["Num"] = 1;
            row["1"] = string.Format("Thân");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Hợi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Dần");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Thân");
            row["10"] = string.Format("Tỵ");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Tam Hợp
            row = dt.NewRow();
            row["Name"] = string.Format("Tam Hợp");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 2;
            row["1"] = string.Format("Ngọ/Tuất");
            row["2"] = string.Format("Mùi/Hợi");
            row["3"] = string.Format("Thân/Tý");
            row["4"] = string.Format("Dậu/Sửu");
            row["5"] = string.Format("Tuất/Dần");
            row["6"] = string.Format("Hợi/Mão");
            row["7"] = string.Format("Tý/Thìn");
            row["8"] = string.Format("Sửu/Tỵ");
            row["9"] = string.Format("Dần/Ngọ");
            row["10"] = string.Format("Mão/Mùi");
            row["11"] = string.Format("Thìn/Thân");
            row["12"] = string.Format("Tỵ/Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Lục Hợp
            row = dt.NewRow();
            row["Name"] = string.Format("Lục Hợp");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Dậu");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Mùi");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Thìn");
            row["9"] = string.Format("Mão");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Mẫu Thương
            row = dt.NewRow();
            row["Name"] = string.Format("Mẫu Thương");
            row["Mean"] = string.Format("Tốt về cầu tài lộc, khai trương");
            row["Num"] = 2;
            row["1"] = string.Format("Hợi/Tý");
            row["2"] = string.Format("Hợi/Tý");
            row["3"] = string.Format("Hợi/Tý");
            row["4"] = string.Format("Dần/Mão");
            row["5"] = string.Format("Dần/Mão");
            row["6"] = string.Format("Dần/Mão");
            row["7"] = string.Format("Thìn/Sửu");
            row["8"] = string.Format("Thìn/Sửu");
            row["9"] = string.Format("Thìn/Sửu");
            row["10"] = string.Format("Thân/Dậu");
            row["11"] = string.Format("Thân/Dậu");
            row["12"] = string.Format("Thân/Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Phúc Hậu
            row = dt.NewRow();
            row["Name"] = string.Format("Phúc Hậu");
            row["Mean"] = string.Format("Tốt về cầu tài lộc, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Tỵ");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Thân");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Thân");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Hợi");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Đại Hồng Sa
            row = dt.NewRow();
            row["Name"] = string.Format("Đại Hồng Sa");
            row["Mean"] = string.Format("Tốt mọi viêc");
            row["Num"] = 2;
            row["1"] = string.Format("Tý/Sửu");
            row["2"] = string.Format("Tý/Sửu");
            row["3"] = string.Format("Tý/Sửu");
            row["4"] = string.Format("Thìn/Tỵ");
            row["5"] = string.Format("Thìn/Tỵ");
            row["6"] = string.Format("Thìn/Tỵ");
            row["7"] = string.Format("Ngọ/Mùi");
            row["8"] = string.Format("Ngọ/Mùi");
            row["9"] = string.Format("Ngọ/Mùi");
            row["10"] = string.Format("Thân/Tuất");
            row["11"] = string.Format("Thân/Tuất");
            row["12"] = string.Format("Thân/Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Dân Nhật
            row = dt.NewRow();
            row["Name"] = string.Format("Dân Nhật (Thời Đức)");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tý");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Hoàng Ân
            row = dt.NewRow();
            row["Name"] = string.Format("Hoàng Ân");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Sửu");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Tý");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Thanh Long
            row = dt.NewRow();
            row["Name"] = string.Format("Thanh Long");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Ngọ");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Tý");
            row["8"] = string.Format("Dần");
            row["9"] = string.Format("Thìn");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Minh Đường
            row = dt.NewRow();
            row["Name"] = string.Format("Minh Đường");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Sửu");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Mùi");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Kim Đường
            row = dt.NewRow();
            row["Name"] = string.Format("Kim Đường");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Dậu");
            row["4"] = string.Format("Hợi");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Ngọc Đường
            row = dt.NewRow();
            row["Name"] = string.Format("Ngọc Đường");
            row["Mean"] = string.Format("Tốt mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Mùi");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Sửu");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #endregion

            return dt;
        }

        public static DataTable BadStar()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            #region Tạo bảng

            //Tạo cột tên sao
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột nội dung
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo số giá trị trong mỗi tháng
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Num";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #region Tạo cột tháng

            //Tháng 1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "1";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "2";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 3
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "3";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 4
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "4";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 5
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "5";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 6
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "6";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 7
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "7";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 8
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "8";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 9
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "9";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 10
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "10";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 11
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "11";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tháng 12
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "12";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #endregion

            #endregion

            #region Thêm dữ liệu vào bảng

            #region Thiên Cương
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Cương (Diệt Môn)");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Lại
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Lại");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Dậu");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Mão");
            row["4"] = string.Format("Tý");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Mão");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Ngục
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Ngục");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Hỏa
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Hỏa");
            row["Mean"] = string.Format("Xấu về lợp nhà");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Tiểu Hồng Sa
            row = dt.NewRow();
            row["Name"] = string.Format("Tiểu Hồng Sa");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Sửu");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Tỵ");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Đại Hao
            row = dt.NewRow();
            row["Name"] = string.Format("Đại Hao (Tử khí, quan phú)");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Thân");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Tuất");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Tý");
            row["8"] = string.Format("Sửu");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Thìn");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #region Tiểu Hao
            row = dt.NewRow();
            row["Name"] = string.Format("Tiểu Hao");
            row["Mean"] = string.Format("Xấu về kinh doanh, cầu tài");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Phá
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Phá");
            row["Mean"] = string.Format("Xấu về xây dựng nhà cửa");
            row["Num"] = 2;
            row["1"] = string.Format("Thân/");
            row["2"] = string.Format("Dậu/Tuất");
            row["3"] = string.Format("Tuất/");
            row["4"] = string.Format("Hợi/");
            row["5"] = string.Format("Tý/Sửu");
            row["6"] = string.Format("Sửu/");
            row["7"] = string.Format("Dần/");
            row["8"] = string.Format("Mão/Thìn");
            row["9"] = string.Format("Thìn/");
            row["10"] = string.Format("Tỵ/");
            row["11"] = string.Format("Ngọ/Mùi");
            row["12"] = string.Format("Mùi/");
            dt.Rows.Add(row);
            #endregion

            #region Kiếp Sát
            row = dt.NewRow();
            row["Name"] = string.Format("Kiếp Sát");
            row["Mean"] = string.Format("Kỵ xuất hành, giá thú, an táng, xây dựng");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Hợi");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Dần");
            row["9"] = string.Format("Hợi");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Tỵ");
            row["12"] = string.Format("Dần");
            dt.Rows.Add(row);
            #endregion

            #region Địa Phá
            row = dt.NewRow();
            row["Name"] = string.Format("Địa Phá");
            row["Mean"] = string.Format("Kỵ xây dựng");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Thổ Phủ
            row = dt.NewRow();
            row["Name"] = string.Format("Thổ Phủ");
            row["Mean"] = string.Format("Kỵ xây dựng, động thổ");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Thân");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Thổ Ôn
            row = dt.NewRow();
            row["Name"] = string.Format("Thổ Ôn (Thiên Cẩu)");
            row["Mean"] = string.Format("Kỵ xây dựng, đào ao, đào giếng, xấu về tế tự");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Ôn
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Ôn");
            row["Mean"] = string.Format("Kỵ xây dựng");
            row["Num"] = 1;
            row["1"] = string.Format("Mùi");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Thụ Tử
            row = dt.NewRow();
            row["Name"] = string.Format("Thụ Tử");
            row["Mean"] = string.Format("Xấu mọi việc (trừ săn bắn tốt)");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Sửu");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Hoang Vu
            row = dt.NewRow();
            row["Name"] = string.Format("Hoang Vu");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 4;
            row["1"] = string.Format("Tỵ/Dậu/Sửu");
            row["2"] = string.Format("Tỵ/Dậu/Sửu");
            row["3"] = string.Format("Tỵ/Dậu/Sửu");
            row["4"] = string.Format("Thân/Tý/Thìn");
            row["5"] = string.Format("Thân/Tý/Thìn");
            row["6"] = string.Format("Thân/Tý/Thìn");
            row["7"] = string.Format("Hợi/Mão/Mùi");
            row["8"] = string.Format("Hợi/Mão/Mùi");
            row["9"] = string.Format("Hợi/Mão/Mùi");
            row["10"] = string.Format("Dần/Ngọ/Tuất");
            row["11"] = string.Format("Dần/Ngọ/Tuất");
            row["12"] = string.Format("Dần/Ngọ/Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Tặc
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Tặc");
            row["Mean"] = string.Format("Xấu đối với khởi tạo, động thổ, nhập trạch, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Thân");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Địa Tặc
            row = dt.NewRow();
            row["Name"] = string.Format("Địa Tặc");
            row["Mean"] = string.Format("Xấu đối với khởi tạo, an táng, động thổ, xuất hành");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Dần");
            dt.Rows.Add(row);
            #endregion

            #region Hỏa Tai
            row = dt.NewRow();
            row["Name"] = string.Format("Hỏa Tai");
            row["Mean"] = string.Format("Xấu đối với làm nhà, lợp nhà");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Dần");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Hỏa
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Hỏa");
            row["Mean"] = string.Format("Xấu đối với lợp nhà, làm bếp");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Mão");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Ngọ");
            dt.Rows.Add(row);
            #endregion

            #region Độc Hỏa
            row = dt.NewRow();
            row["Name"] = string.Format("Độc Hỏa");
            row["Mean"] = string.Format("Xấu đối với lợp nhà, làm bếp");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Mão");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Ngọ");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Yếm Đại Họa
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Yếm Đại Hỏa");
            row["Mean"] = string.Format("Xấu đối với xuất hành, giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Thân");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Tỵ");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Hư
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Hư (Nguyệt Sát)");
            row["Mean"] = string.Format("Xấu đối với việc giá thú, mở cửa, mở hàng");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Thìn");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Thìn");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Hoàng Sa
            row = dt.NewRow();
            row["Name"] = string.Format("Hoàng Sa");
            row["Mean"] = string.Format("Xấu đối với xuất hành");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Ngọ");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Dần");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Ngọ");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Lục Bất Thành
            row = dt.NewRow();
            row["Name"] = string.Format("Lục Bất Thành");
            row["Mean"] = string.Format("Xấu đối với xây dựng");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Tỵ");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Sửu");
            row["7"] = string.Format("Thân");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Thìn");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Nhân Cách
            row = dt.NewRow();
            row["Name"] = string.Format("Nhân Cách");
            row["Mean"] = string.Format("Xấu đối với giá thú, khởi tạo");
            row["Num"] = 1;
            row["1"] = string.Format("Dậu");
            row["2"] = string.Format("Mùi");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Thần Cách
            row = dt.NewRow();
            row["Name"] = string.Format("Thần Cách");
            row["Mean"] = string.Format("Kỵ tế tự");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Hợi");
            row["5"] = string.Format("Dậu");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Phi Ma Sát
            row = dt.NewRow();
            row["Name"] = string.Format("Phi Ma Sát (Tai Sát)");
            row["Mean"] = string.Format("Kỵ giá thú nhập trạch");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Ngũ Quý
            row = dt.NewRow();
            row["Name"] = string.Format("Ngũ Quý");
            row["Mean"] = string.Format("Kỵ xuất hành");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Dần");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Thân");
            row["7"] = string.Format("Sửu");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Băng Tiêu Ngọa Hãm
            row = dt.NewRow();
            row["Name"] = string.Format("Băng Tiêu Ngọa Hãm");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Hà Khôi
            row = dt.NewRow();
            row["Name"] = string.Format("Hà Khôi");
            row["Mean"] = string.Format("Kỵ khởi công xây nhà cửa, xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Cấu Giảo
            row = dt.NewRow();
            row["Name"] = string.Format("Cấu Giảo");
            row["Mean"] = string.Format("Kỵ khởi công xây nhà cửa, xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Ngọ");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Vãng Vong
            row = dt.NewRow();
            row["Name"] = string.Format("Vãng Vong (Thổ Kỵ)");
            row["Mean"] = string.Format("Kỵ xuất hành, giá thú, cầu tài lộc, động thổ");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Thân");
            row["4"] = string.Format("Hợi");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Tý");
            row["9"] = string.Format("Thìn");
            row["10"] = string.Format("Mùi");
            row["11"] = string.Format("Tuất");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Cửu Không
            row = dt.NewRow();
            row["Name"] = string.Format("Cửu Không");
            row["Mean"] = string.Format("Kỵ xuất hành, cầu tài, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Sửu");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Tý");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #region Trùng Tang
            row = dt.NewRow();
            row["Name"] = string.Format("Trùng Tang");
            row["Mean"] = string.Format("Kỵ giá thú, an táng, khởi công xây nhà");
            row["Num"] = 1;
            row["1"] = string.Format("Giáp");
            row["2"] = string.Format("Ất");
            row["3"] = string.Format("Kỷ");
            row["4"] = string.Format("Bính");
            row["5"] = string.Format("Đinh");
            row["6"] = string.Format("Kỷ");
            row["7"] = string.Format("Canh");
            row["8"] = string.Format("Tân");
            row["9"] = string.Format("Kỷ");
            row["10"] = string.Format("Nhâm");
            row["11"] = string.Format("Quý");
            row["12"] = string.Format("Kỷ");
            dt.Rows.Add(row);
            #endregion

            #region Trùng Phục
            row = dt.NewRow();
            row["Name"] = string.Format("Trùng Phục");
            row["Mean"] = string.Format("Kỵ giá thú, an táng");
            row["Num"] = 1;
            row["1"] = string.Format("Canh");
            row["2"] = string.Format("Tân");
            row["3"] = string.Format("Kỷ");
            row["4"] = string.Format("Nhâm");
            row["5"] = string.Format("Quý");
            row["6"] = string.Format("Mậu");
            row["7"] = string.Format("Giáp");
            row["8"] = string.Format("Ất");
            row["9"] = string.Format("Kỷ");
            row["10"] = string.Format("Nhâm");
            row["11"] = string.Format("Quý");
            row["12"] = string.Format("Kỷ");
            dt.Rows.Add(row);
            #endregion

            #region Chu Tước Hắc Đạo
            row = dt.NewRow();
            row["Name"] = string.Format("Chu Tước Hắc Đạo");
            row["Mean"] = string.Format("Kỵ nhập trạch, khai trương");
            row["Num"] = 1;
            row["1"] = string.Format("Mão");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Dậu");
            row["5"] = string.Format("Hợi");
            row["6"] = string.Format("Sửu");
            row["7"] = string.Format("Mão");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Hợi");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Bạch Hổ
            row = dt.NewRow();
            row["Name"] = string.Format("Bạch Hổ (trùng ngày với Thiên Giải (sao tốt))");
            row["Mean"] = string.Format("Kỵ mai táng");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Thân");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Tý");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Huyền Vũ
            row = dt.NewRow();
            row["Name"] = string.Format("Huyền Vũ");
            row["Mean"] = string.Format("Kỵ mai táng");
            row["Num"] = 1;
            row["1"] = string.Format("Dậu");
            row["2"] = string.Format("Hợi");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Sửu");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Mùi");
            dt.Rows.Add(row);
            #endregion

            #region Câu Trận
            row = dt.NewRow();
            row["Name"] = string.Format("Câu Trận");
            row["Mean"] = string.Format("Kỵ mai táng");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Mùi");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Sửu");
            row["10"] = string.Format("Mão");
            row["11"] = string.Format("Mùi");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Lôi Công
            row = dt.NewRow();
            row["Name"] = string.Format("Lôi Công");
            row["Mean"] = string.Format("Xấu với xây dựng nhà cửa");
            row["Num"] = 1;
            row["1"] = string.Format("Dần");
            row["2"] = string.Format("Hợi");
            row["3"] = string.Format("Tỵ");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Hợi");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Thân");
            row["9"] = string.Format("Dần");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Tỵ");
            row["12"] = string.Format("Thân");
            dt.Rows.Add(row);
            #endregion

            #region Cô Thần
            row = dt.NewRow();
            row["Name"] = string.Format("Cô Thần");
            row["Mean"] = string.Format("Xấu với giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Hợi");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Sửu");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Thìn");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Mùi");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Quả Tú
            row = dt.NewRow();
            row["Name"] = string.Format("Quả Tú");
            row["Mean"] = string.Format("Xấu với giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Ngọ");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dậu");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Tý");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Mão");
            dt.Rows.Add(row);
            #endregion

            #region Sát Chủ
            row = dt.NewRow();
            row["Name"] = string.Format("Sát Chủ");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Sửu");
            row["8"] = string.Format("Hợi");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Dần");
            row["12"] = string.Format("Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Hình
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Hình");
            row["Mean"] = string.Format("Xấu mọi việc");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Sửu");
            row["7"] = string.Format("Dần");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Hợi");
            row["11"] = string.Format("Mão");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Tội Chỉ
            row = dt.NewRow();
            row["Name"] = string.Format("Tội Chỉ");
            row["Mean"] = string.Format("Xấu với tế tự, kiện cáo");
            row["Num"] = 1;
            row["1"] = string.Format("Ngọ");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Mùi");
            row["4"] = string.Format("Sửu");
            row["5"] = string.Format("Thân");
            row["6"] = string.Format("Dần");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Thìn");
            row["11"] = string.Format("Hợi");
            row["12"] = string.Format("Tỵ");
            dt.Rows.Add(row);
            #endregion

            #region Nguyệt Kiến Chuyển Sát
            row = dt.NewRow();
            row["Name"] = string.Format("Nguyệt Kiến Chuyển Sát");
            row["Mean"] = string.Format("Kỵ động thổ");
            row["Num"] = 1;
            row["1"] = string.Format("Mão");
            row["2"] = string.Format("Mão");
            row["3"] = string.Format("Mão");
            row["4"] = string.Format("Ngọ");
            row["5"] = string.Format("Ngọ");
            row["6"] = string.Format("Ngọ");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Địa Chính Chuyển
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Địa Chính Chuyển");
            row["Mean"] = string.Format("Kỵ động thổ");
            row["Num"] = 3;
            row["1"] = string.Format("Quý Mão");
            row["2"] = string.Format("Quý Mão");
            row["3"] = string.Format("Quý Mão");
            row["4"] = string.Format("Bính Ngọ");
            row["5"] = string.Format("Bính Ngọ");
            row["6"] = string.Format("Bính Ngọ");
            row["7"] = string.Format("Đinh Dậu");
            row["8"] = string.Format("Đinh Dậu");
            row["9"] = string.Format("Đinh Dậu");
            row["10"] = string.Format("Canh Tý");
            row["11"] = string.Format("Canh Tý");
            row["12"] = string.Format("Canh Tý");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Địa Chuyển Sát 
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Địa Chuyển Sát");
            row["Mean"] = string.Format("Kỵ động thổ");
            row["Num"] = 3;
            row["1"] = string.Format("Ất Mão");
            row["2"] = string.Format("Ất Mão");
            row["3"] = string.Format("Ất Mão");
            row["4"] = string.Format("Bính Ngọ");
            row["5"] = string.Format("Bính Ngọ");
            row["6"] = string.Format("Bính Ngọ");
            row["7"] = string.Format("Tân Dậu");
            row["8"] = string.Format("Tân Dậu");
            row["9"] = string.Format("Tân Dậu");
            row["10"] = string.Format("Nhâm Tý");
            row["11"] = string.Format("Nhâm Tý");
            row["12"] = string.Format("Nhâm Tý");
            dt.Rows.Add(row);
            #endregion

            #region Lỗ Ban Sát
            row = dt.NewRow();
            row["Name"] = string.Format("Lỗ Ban Sát");
            row["Mean"] = string.Format("Kỵ khởi tạo");
            row["Num"] = 1;
            row["1"] = string.Format("Tý");
            row["2"] = string.Format("Tý");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Mão");
            row["5"] = string.Format("Mão");
            row["6"] = string.Format("Mão");
            row["7"] = string.Format("Ngọ");
            row["8"] = string.Format("Ngọ");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Dậu");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Dậu");
            dt.Rows.Add(row);
            #endregion

            #region Phủ Đầu Sát
            row = dt.NewRow();
            row["Name"] = string.Format("Phủ Đầu Sát");
            row["Mean"] = string.Format("Kỵ khởi tạo");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Mùi");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Dậu");
            row["8"] = string.Format("Dậu");
            row["9"] = string.Format("Dậu");
            row["10"] = string.Format("Tý");
            row["11"] = string.Format("Tý");
            row["12"] = string.Format("Tý");
            dt.Rows.Add(row);
            #endregion

            #region Tam Tang
            row = dt.NewRow();
            row["Name"] = string.Format("Tam Tang");
            row["Mean"] = string.Format("Kỵ khởi tạo, giá thú, an táng");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Thìn");
            row["3"] = string.Format("Thìn");
            row["4"] = string.Format("Mùi");
            row["5"] = string.Format("Mùi");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Sửu");
            row["11"] = string.Format("Sửu");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Ngũ Hư
            row = dt.NewRow();
            row["Name"] = string.Format("Ngũ Hư");
            row["Mean"] = string.Format("Kỵ khởi tạo, giá thú, an táng");
            row["Num"] = 1;
            row["1"] = string.Format("Tỵ");
            row["2"] = string.Format("Dậu");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Thân");
            row["5"] = string.Format("Tý");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Hợi");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Dần");
            row["11"] = string.Format("Ngọ");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Tứ Thời Đại Mộ
            row = dt.NewRow();
            row["Name"] = string.Format("Tứ Thời Đại Mộ");
            row["Mean"] = string.Format("Kỵ an táng");
            row["Num"] = 3;
            row["1"] = string.Format("Ất Mùi");
            row["2"] = string.Format("Ất Mùi");
            row["3"] = string.Format("Ất Mùi");
            row["4"] = string.Format("Bính Tuất");
            row["5"] = string.Format("Bính Tuất");
            row["6"] = string.Format("Bính Tuất");
            row["7"] = string.Format("Tân Sửu");
            row["8"] = string.Format("Tân Sửu");
            row["9"] = string.Format("Tân Sửu");
            row["10"] = string.Format("Nhâm Thìn");
            row["11"] = string.Format("Nhâm Thìn");
            row["12"] = string.Format("Nhâm Thìn");
            dt.Rows.Add(row);
            #endregion

            #region Thổ Cẩm
            row = dt.NewRow();
            row["Name"] = string.Format("Thổ Cẩm");
            row["Mean"] = string.Format("Kỵ xây dựng, an táng");
            row["Num"] = 1;
            row["1"] = string.Format("Hợi");
            row["2"] = string.Format("Hợi");
            row["3"] = string.Format("Hợi");
            row["4"] = string.Format("Dần");
            row["5"] = string.Format("Dần");
            row["6"] = string.Format("Dần");
            row["7"] = string.Format("Tỵ");
            row["8"] = string.Format("Tỵ");
            row["9"] = string.Format("Tỵ");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Thân");
            row["12"] = string.Format("Thân");
            dt.Rows.Add(row);
            #endregion

            #region Ly Sàng
            row = dt.NewRow();
            row["Name"] = string.Format("Ly Sàng");
            row["Mean"] = string.Format("Kỵ giá thú");
            row["Num"] = 2;
            row["1"] = string.Format("Dậu/");
            row["2"] = string.Format("Dậu/");
            row["3"] = string.Format("Dậu/");
            row["4"] = string.Format("Dần/Ngọ");
            row["5"] = string.Format("Dần/Ngọ");
            row["6"] = string.Format("Dần/Ngọ");
            row["7"] = string.Format("Tuất/");
            row["8"] = string.Format("Tuất/");
            row["9"] = string.Format("Tuất/");
            row["10"] = string.Format("Tỵ/");
            row["11"] = string.Format("Tỵ/");
            row["12"] = string.Format("Tỵ/");
            dt.Rows.Add(row);
            #endregion

            #region Tứ Thời Cô Quả
            row = dt.NewRow();
            row["Name"] = string.Format("Tứ Thời Cô Quả");
            row["Mean"] = string.Format("Kỵ giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Sửu");
            row["2"] = string.Format("Sửu");
            row["3"] = string.Format("Sửu");
            row["4"] = string.Format("Thìn");
            row["5"] = string.Format("Thìn");
            row["6"] = string.Format("Thìn");
            row["7"] = string.Format("Mùi");
            row["8"] = string.Format("Mùi");
            row["9"] = string.Format("Mùi");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Tuất");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #region Không Phòng
            row = dt.NewRow();
            row["Name"] = string.Format("Không Phòng");
            row["Mean"] = string.Format("Kỵ giá thú");
            row["Num"] = 1;
            row["1"] = string.Format("Thìn");
            row["2"] = string.Format("Tỵ");
            row["3"] = string.Format("Tý");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Hợi");
            row["6"] = string.Format("Mùi");
            row["7"] = string.Format("Dần");
            row["8"] = string.Format("Mão");
            row["9"] = string.Format("Ngọ");
            row["10"] = string.Format("Thân");
            row["11"] = string.Format("Dậu");
            row["12"] = string.Format("Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Âm Thác
            row = dt.NewRow();
            row["Name"] = string.Format("Âm Thác");
            row["Mean"] = string.Format("Kỵ xuất hành, giá thú, an táng");
            row["Num"] = 3;
            row["1"] = string.Format("Canh Tuất");
            row["2"] = string.Format("Tân Dậu");
            row["3"] = string.Format("Canh Thân");
            row["4"] = string.Format("Đinh Mùi");
            row["5"] = string.Format("Bính Ngọ");
            row["6"] = string.Format("Đinh Tỵ");
            row["7"] = string.Format("Giáp Thìn");
            row["8"] = string.Format("Ất Mão");
            row["9"] = string.Format("Giáp Dần");
            row["10"] = string.Format("Quý Sửu");
            row["11"] = string.Format("Nhâm Tý");
            row["12"] = string.Format("Quý Hợi");
            dt.Rows.Add(row);
            #endregion

            #region Dương Thác
            row = dt.NewRow();
            row["Name"] = string.Format("Dương Thác");
            row["Mean"] = string.Format("Kỵ xuất hành, giá thú, an táng");
            row["Num"] = 3;
            row["1"] = string.Format("Giáp Dần");
            row["2"] = string.Format("Ất Mão");
            row["3"] = string.Format("Giáp Thìn");
            row["4"] = string.Format("Đinh Tý");
            row["5"] = string.Format("Bính Ngọ");
            row["6"] = string.Format("Đinh Mùi");
            row["7"] = string.Format("Canh Thân");
            row["8"] = string.Format("Tân Dậu");
            row["9"] = string.Format("Canh Tuất");
            row["10"] = string.Format("Quý Hợi");
            row["11"] = string.Format("Nhâm Tý");
            row["12"] = string.Format("Quý Sửu");
            dt.Rows.Add(row);
            #endregion

            #region Quỷ Khóc
            row = dt.NewRow();
            row["Name"] = string.Format("Quỷ Khốc");
            row["Mean"] = string.Format("Xấu với tế tự, mai táng");
            row["Num"] = 1;
            row["1"] = string.Format("Tuất");
            row["2"] = string.Format("Tuất");
            row["3"] = string.Format("Tuất");
            row["4"] = string.Format("Tuất");
            row["5"] = string.Format("Tuất");
            row["6"] = string.Format("Tuất");
            row["7"] = string.Format("Tuất");
            row["8"] = string.Format("Tuất");
            row["9"] = string.Format("Tuất");
            row["10"] = string.Format("Tuất");
            row["11"] = string.Format("Tuất");
            row["12"] = string.Format("Tuất");
            dt.Rows.Add(row);
            #endregion

            #endregion

            return dt;
        }
        #endregion

        #region Tìm sao tốt,sao xấu
        public DataTable GetGoodStar(DateTime date)
        {
            DataTable dt = GoodStar();
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            string sMonth = string.Format("{0}", luni.Month);
            string sCan = GetCanNgay(date);
            string sChi = GetChiNgay(date);

            DataTable gdt = new DataTable();
            DataColumn column;
            //Tạo cột tên sao
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            //Tạo cột nội dung
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = false;
            gdt.Columns.Add(column);

            foreach (DataRow row in dt.Rows)
            {
                int num = (int)row["num"];
                if (num == 1)
                {
                    string s = (string)row[sMonth];
                    if (sCan == s || sChi == s)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
                else if (num == 2)
                {
                    string s = (string)row[sMonth];
                    string[] ss = s.Split('/');
                    if (ss[0] == sCan || ss[0] == sChi || ss[1] == sCan || ss[1] == sChi)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
                else if (num == 3)
                {
                    string s = (string)row[sMonth];
                    if (s == luni.DayName)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
            }

            return gdt;
        }

        public DataTable GetBadStar(DateTime date)
        {
            DataTable dt = BadStar();
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            string sMonth = string.Format("{0}", luni.Month);
            string sCan = GetCanNgay(date);
            string sChi = GetChiNgay(date);

            DataTable gdt = new DataTable();
            DataColumn column;
            //Tạo cột tên sao
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            //Tạo cột nội dung
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = false;
            gdt.Columns.Add(column);

            foreach (DataRow row in dt.Rows)
            {
                int num = (int)row["num"];
                if (num == 1)
                {
                    string s = (string)row[sMonth];
                    if (sCan == s || sChi == s)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
                else if (num == 2)
                {
                    string s = (string)row[sMonth];
                    string[] ss = s.Split('/');
                    if (ss[0] == sCan || ss[0] == sChi || ss[1] == sCan || ss[1] == sChi)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
                else if (num == 3)
                {
                    string s = (string)row[sMonth];
                    if (s == luni.DayName)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
                else if (num == 4)
                {
                    string s = (string)row[sMonth];
                    string[] ss = s.Split('/');
                    if (ss[0] == sCan || ss[0] == sChi || ss[1] == sCan || ss[1] == sChi || ss[2] == sCan || ss[2] == sChi)
                    {
                        DataRow grow = gdt.NewRow();
                        grow["Name"] = row["Name"];
                        grow["Mean"] = row["Mean"];
                        gdt.Rows.Add(grow);
                    }
                }
            }
            return gdt;
        }
        #endregion

        #region Tìm thông tin theo nhi thập bát tú

        private static String[] star = {"Giác", "Cang", "Đê", "Phòng", "Tâm", "Vĩ", "Cơ",
                        "Đẩu", "Ngưu", "Nữ", "Hư", "Nguy", "Thất", "Bích",
                        "Khuê", "Lâu", "Vị", "Mão", "Tất", "Chủy", "Sâm",
                        "Tỉnh", "Quỷ", "Liễu", "Tinh", "Trương", "Dực", "Chẩn"};

        public static bool IsLessThanDate(DateTime a, DateTime b)
        {
            bool check;
            if (a.Year < b.Year)
                check = true;
            else
            {
                if (a.Year == b.Year)
                {
                    if (a.Month < b.Month)
                        check = true;
                    else
                    {
                        if (a.Month == b.Month)
                        {
                            if (a.Day < b.Day)
                                check = true;
                            else
                                check = false;
                        }
                        else
                            check = false;
                    }
                }
                else
                    check = false;
            }
            return check;
        }

        public static bool IsMoreThanDate(DateTime a, DateTime b)
        {
            bool check;
            if (a.Year > b.Year)
                check = true;
            else
            {
                if (a.Year == b.Year)
                {
                    if (a.Month > b.Month)
                        check = true;
                    else
                    {
                        if (a.Month == b.Month)
                        {
                            if (a.Day > b.Day)
                                check = true;
                            else
                                check = false;
                        }
                        else
                            check = false;
                    }
                }
                else
                    check = false;
            }
            return check;
        }

        public static String GetStar28(DateTime date)
        {
            long iStar = 13;
            long numDays = Math.Abs(ChangeDateToJuliusDay(1, 1, 1997) - ChangeDateToJuliusDay(date.Day, date.Month, date.Year));
            if (IsLessThanDate(date, new DateTime(1997, 1, 1)))
                iStar = (iStar - numDays % 28 + 28) % 28;
            else
            {
                if (IsMoreThanDate(date, new DateTime(1997, 1, 1)))
                    iStar = (iStar + numDays % 28) % 28;
            }
            return star[iStar];
        }

        private static string FileText(String fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, @"NhiThapBatTu\", fileName);
            return filePath;
        }
        public String GetSao(DateTime date)
        {
            return GetStar28(date);
        }
        public String GetDetailStar28(DateTime date)
        {

            string s = GetStar28(date);
            int num = -1;

            for (int i = 0; i < star.Length; i++)
            {
                if (star[i] == s)
                    num = i;
            }
            if (num == -1)
                return "";
            switch(num)
            {
                case 0:
                    return s0;
                case 1:
                    return s1;
                case 2:
                    return s2;
                case 3:
                    return s3;
                case 4:
                    return s4;
                case 5:
                    return s5;
                case 6:
                    return s6;
                case 7:
                    return s7;
                case 8:
                    return s8;
                case 9:
                    return s9;
                case 10:
                    return s10;
                case 11:
                    return s11;
                case 12:
                    return s12;
                case 13:
                    return s13;
                case 14:
                    return s14;
                case 15:
                    return s15;
                case 16:
                    return s16;
                case 17:
                    return s17;
                case 18:
                    return s18;
                case 19:
                    return s19;
                case 20:
                    return s20;
                case 21:
                    return s21;
                case 22:
                    return s22;
                case 23:
                    return s23;
                case 24:
                    return s24;
                case 25:
                    return s25;
                case 26:
                    return s26;
                case 27:
                    return s27;
                default:
                    return "";
            }
        }
        public static string s0 = "";
        public static string s1 = "";
        public static string s2 = "";
        public static string s3 = "";
        public static string s4 = "";
        public static string s5 = "";
        public static string s6 = "";
        public static string s7 = "";
        public static string s8 = "";
        public static string s9 = "";
        public static string s10 = "";
        public static string s11 = "";
        public static string s12 = "";
        public static string s13 = "";
        public static string s14 = "";
        public static string s15 = "";
        public static string s16 = "";
        public static string s17 = "";
        public static string s18 = "";
        public static string s19 = "";
        public static string s20 = "";
        public static string s21 = "";
        public static string s22 = "";
        public static string s23 = "";
        public static string s24 = "";
        public static string s25 = "";
        public static string s26 = "";
        public static string s27 = "";
        public static string GetStringStar(int num)
        {
            StreamReader streamReader = new StreamReader(FileText(string.Format("{0}.txt", num)), Encoding.UTF8);
            string detail = streamReader.ReadToEnd();
            return detail;
        }
        public static void ReadFileStar()
        {
            s0 = GetStringStar(0);
            s1 = GetStringStar(1);
            s2 = GetStringStar(2);
            s3 = GetStringStar(3);
            s4 = GetStringStar(4);
            s5 = GetStringStar(5);
            s6 = GetStringStar(6);
            s7 = GetStringStar(7);
            s8 = GetStringStar(8);
            s9 = GetStringStar(9);
            s10 = GetStringStar(10);
            s11 = GetStringStar(11);
            s12 = GetStringStar(12);
            s13 = GetStringStar(13);
            s14 = GetStringStar(14);
            s15 = GetStringStar(15);
            s16 = GetStringStar(16);
            s17 = GetStringStar(17);
            s18 = GetStringStar(18);
            s19 = GetStringStar(19);
            s20 = GetStringStar(20);
            s21 = GetStringStar(21);
            s22 = GetStringStar(22);
            s23 = GetStringStar(23);
            s24 = GetStringStar(24);
            s25 = GetStringStar(25);
            s26 = GetStringStar(26);
            s27 = GetStringStar(27);
        }
        #endregion

        #region Lịch xuất hành của cụ Khổng Minh
        public static DataTable XuatHanhKhongMinh()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            #region Tạo bảng

            //Tạo cột tên ngày xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột ý nghĩa ngày xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột tháng chứa ngày xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Month";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột ngày có ngày xuất hành tương ứng
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Day";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #endregion

            #region Thêm dữ liệu vào bảng

            #region Hảo Thương
            row = dt.NewRow();
            row["Name"] =string.Format("Hảo Thương");
            row["Mean"] = string.Format("Xuất hành thuận lợi, gặp người lớn vừa lòng, làm việc việc như ý muốn, áo phẩm vinh quy.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("6,12,18,24,30");
            dt.Rows.Add(row);
            #endregion

            #region Đạo Tặc
            row = dt.NewRow();
            row["Name"] = string.Format("Đạo Tặc");
            row["Mean"] = string.Format("Rất xấu. Xuất hành bị hại, mất của.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("5,11,17,23,29");
            dt.Rows.Add(row);
            #endregion

            #region Thuần Dương
            row = dt.NewRow();
            row["Name"] = string.Format("Thuần Dương");
            row["Mean"] = string.Format("Xuất hành tốt, lúc về cũng tốt, nhiều thuận lợi, được người tốt giúp đỡ, cầu tài được như ý muốn, tranh luận thường thắng lợi.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("4,10,16,22,28");
            dt.Rows.Add(row);
            #endregion

            #region Đường Phong
            row = dt.NewRow();
            row["Name"] = string.Format("Đường Phong");
            row["Mean"] = string.Format("Rất tốt. Xuất hành thuận lợi, cầu tài được như ý muốn, gặp quý nhân phù trợ.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("1,7,13,19,25");
            dt.Rows.Add(row);
            #endregion

            #region Kim Thổ
            row = dt.NewRow();
            row["Name"] = string.Format("Kim Thổ");
            row["Mean"] = string.Format("Ra đi nhỡ tàu, nhỡ xe, cầu tài không được, trên đường đi mất của, bất lợi.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("2,8,14,20,26");
            dt.Rows.Add(row);
            #endregion

            #region Kim Dương
            row = dt.NewRow();
            row["Name"] = string.Format("Kim Dương");
            row["Mean"] = string.Format("Xuất hành tốt, có quý nhân phù trợ, tài lộc thông suốt, thưa kiện có nhiều lý phải.");
            row["Month"] = string.Format("1,4,7,10");
            row["Day"] = string.Format("3,9,15,21,27");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Đạo
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Đạo");
            row["Mean"] = string.Format("Xuất hành cầu tài nên tránh, dù được cũng rất tốn kém, thất lý mà thua.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("1,9,17,25");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Thương
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Thương");
            row["Mean"] = string.Format("Xuất hành để gặp cấp trên thì tuyệt vời, cầu tài thì được tài. Mọi việc đều thuận lợi.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("8,16,24,30");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Hầu
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Hầu");
            row["Mean"] = string.Format("Xuất hành dù ít hay nhiều cũng cãi cọ, phải tránh xẩy ra tai nạn chảy máu, máu sẽ khó cầm.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("7,15,23");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Dương
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Dương");
            row["Mean"] = string.Format("Xuất hành tốt, cầu tài được tài. Hỏi vợ được vợ. Mọi việc đều như ý muốn.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("6,14,22");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Môn
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Môn");
            row["Mean"] = string.Format("Xuất hành làm mọi việc đều vừa ý, cầu được ước thấy mọi việc đều thành đạt.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("2,10,18,26");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Đường
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Đường");
            row["Mean"] = string.Format("Xuất hành tốt, quý nhân phù trợ, buôn bán may mắn, mọi việc đều như ý.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("3,11,19,27");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Tài
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Tài");
            row["Mean"] = string.Format("Nên xuất hành, cầu tài thắng lợi. Được người tốt giúp đỡ. Mọi việc đều thuận.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("4,12,20,28");
            dt.Rows.Add(row);
            #endregion

            #region Thiên Tặc
            row = dt.NewRow();
            row["Name"] = string.Format("Thiên Tặc");
            row["Mean"] = string.Format("Xuất hành xấu, cầu tài không được. Đi đường dễ mất cắp. Mọi việc đều rất xấu.");
            row["Month"] = string.Format("2,5,8,11");
            row["Day"] = string.Format("5,13,21,29");
            dt.Rows.Add(row);
            #endregion

            #region Bạch Hổ Đầu
            row = dt.NewRow();
            row["Name"] = string.Format("Bạch Hổ Đầu");
            row["Mean"] = string.Format("Xuất hành, cầu tài đều được. Đi đâu đều thông đạt cả.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("2,10,18,26");
            dt.Rows.Add(row);
            #endregion

            #region Bạch Hổ Kiếp
            row = dt.NewRow();
            row["Name"] = string.Format("Bạch Hổ Kiếp");
            row["Mean"] = string.Format("Xuất hành, cầu tài được như ý muốn, đi hướng Nam và Bắc rất thuận lợi.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("3,11,19,27");
            dt.Rows.Add(row);
            #endregion

            #region Bạch Hổ Túc
            row = dt.NewRow();
            row["Name"] = string.Format("Bạch Hổ Túc");
            row["Mean"] = string.Format("Cấm đi xa, làm việc gì cũng không thành công. Rất xấu trong mọi việc.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("4,12,20,28");
            dt.Rows.Add(row);
            #endregion

            #region Huyền Vũ
            row = dt.NewRow();
            row["Name"] = string.Format("Huyền Vũ");
            row["Mean"] = string.Format("Xuất hành thường gặp cãi cọ, gặp việc xấu, không nên đi.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("5,13,21,29");
            dt.Rows.Add(row);
            #endregion

            #region Chu Tước
            row = dt.NewRow();
            row["Name"] = string.Format("Chu Tước");
            row["Mean"] = string.Format("Xuất hành, cầu tài đều xấu. Hay mất của, kiện cáo thua vì đuối lý.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("1,9,17");
            dt.Rows.Add(row);
            #endregion

            #region Thanh Long Túc
            row = dt.NewRow();
            row["Name"] = string.Format("Thanh Long Túc");
            row["Mean"] = string.Format("Đi xa không nên, xuất hành xấu, tài lộc không có. Kiện cáo cũng đuối lý.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("8,16,24,30");
            dt.Rows.Add(row);
            #endregion

            #region Thanh Long Kiếp
            row = dt.NewRow();
            row["Name"] = string.Format("Thanh Long Kiếp");
            row["Mean"] = string.Format("Xuất hành 4 phương, 8 hướng đều tốt, trăm sự được như ý.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("7,15,23,25");
            dt.Rows.Add(row);
            #endregion

            #region Thanh Long Đầu
            row = dt.NewRow();
            row["Name"] = string.Format("Thanh Long Đầu");
            row["Mean"] = string.Format("Xuất hành nên đi vào sáng sớm. Cầu tài thắng lợi. Mọi việc như ý.");
            row["Month"] = string.Format("3,6,9,12");
            row["Day"] = string.Format("6,14,22");
            dt.Rows.Add(row);
            #endregion

            #endregion

            return dt;
        }
        #endregion

        #region Tìm ngày xuất hành theo lịch xuất hành của Khổng Minh
        public DataTable GetNgayXuatHanh(DateTime date)
        {
            DataTable dt = XuatHanhKhongMinh();
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            int month = luni.Month;
            int day = luni.Day;

            DataTable gdt = new DataTable();
            DataColumn column;
            //Tạo cột tên ngày
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            //Tạo cột ý nghĩa
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            foreach(DataRow row in dt.Rows)
            {
                string sM = (string)row["Month"];
                string sD = (string)row["Day"];
                string[] wordMonth = sM.Split(',');
                string[] wordDay = sD.Split(',');
                foreach (var word in wordMonth)
                {
                    int iMonth = Convert.ToInt32(word);
                    if(iMonth == month)
                    {
                        foreach(var vword in wordDay)
                        {
                            int iDay = Convert.ToInt32(vword);
                            if(iDay == day)
                            {
                                DataRow grow = gdt.NewRow();
                                grow["Name"] = row["Name"];
                                grow["Mean"] = row["Mean"];
                                gdt.Rows.Add(grow);
                                break;
                            }
                        }
                    }
                }
            }

            return gdt;
        }
        #endregion

        #region Giờ Xuất Hành Theo Lý Thuần Phong
        public static DataTable GioXuatHanh()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            #region Tạo bảng

            //Tạo cột Số dư để tìm giờ xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Num";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột tên giờ xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            //Tạo cột ý nghĩa giờ xuất hành
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            #endregion

            #region Thêm dữ liệu vào bảng

            #region Tuyệt Lộ
            row = dt.NewRow();
            row["Num"] = 0;
            row["Name"] = string.Format("Tuyệt Lộ");
            row["Mean"] = string.Format("Cầu tài không có lợi, hay bị trái ý, ra đi hay gặp nạn, việc quan trọng phải đòn, gặp ma quỷ cúng tế mới an."); 
            dt.Rows.Add(row);
            #endregion

            #region Đại An
            row = dt.NewRow();
            row["Num"] = 1;
            row["Name"] = string.Format("Đại An");
            row["Mean"] = string.Format("Mọi việc đểu tốt lành, cầu tài đi hướng Tây Nam – Nhà cửa yên lành. Người xuất hành đều bình yên.");
            dt.Rows.Add(row);
            #endregion

            #region Tốc Hỷ
            row = dt.NewRow();
            row["Num"] = 2;
            row["Name"] = string.Format("Tốc Hỷ");
            row["Mean"] = string.Format("Vui sắp tới, cầu tài đi hướng Nam. Đi việc gặp gỡ các Quan nhiều may mắn. Chăn nuôi đều thuận lợi, người đi có tin về."); 
            dt.Rows.Add(row);
            #endregion

            #region Lưu Niên
            row = dt.NewRow();
            row["Num"] = 3;
            row["Name"] = string.Format("Lưu Niên");
            row["Mean"] = string.Format("Nghiệp khó thành, cầu tài mờ mịt. Kiện các nên hoãn lại. Người đi chưa có tin về. Mất của, đi hướng Nam tìm nhanh mới thấy. Nên phòng ngừa cãi cọ. Miệng tiếng rất tầm thường. Việc làm chậm, lâu la nhưng làm gì đều chắc chắn.");
            dt.Rows.Add(row);
            #endregion

            #region Xích Khẩu
            row = dt.NewRow();
            row["Num"] = 4;
            row["Name"] = string.Format("Xích Khẩu");
            row["Mean"] = string.Format("Hay cãi cọ, gây chuyện đói kém, phải nên phòng. Người ra đi nên hoãn lại. Phòng người người nguyền rủa, tránh lây bệnh. (Nói chung khi có việc hội họp, việc quan, tranh luận…Tránh đi vào giờ này, nếu bắt buộc phải đi thì nên giữ miệng dễ gây ẩu đả cãi nhau).");
            dt.Rows.Add(row);
            #endregion

            #region Tiểu Các (Tiểu Cát)
            row = dt.NewRow();
            row["Num"] = 5;
            row["Name"] = string.Format("Tiểu Các");
            row["Mean"] = string.Format("Rất tốt lành, đi thường gặp may mắn. Buôn bán có lời. Phụ nữ có tin mừng, người đi sắp về nhà. Mọi việc đều hòa hợp. Có bệnh cầu sẽ khỏi, người nhà đều mạnh khỏe.");
            dt.Rows.Add(row);
            #endregion

            #endregion

            return dt;
        }
        #endregion

        #region Tìm giờ xuất hành theo Lý Thuần Phong

        #region Công thức tính giờ theo lịch xuất hành của Lý Thuần Phong
        public int CongThucTinhGio(DateTime date, int num)
        {
            int result;
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            int month = luni.Month;
            int day = luni.Day;

            result = ((month + day + num) - 2) % 6;

            return result;
        }
        #endregion

        #region Chú thích về công thức
        //Từ 23h - 1h và từ 11h - 13h: Khăc 1
        //Từ 1h - 3h và từ 13h - 15h: Khắc 2
        //Từ 3h - 5h và từ 15h - 17h: Khắc 3
        //Từ 5h - 7h và từ 17h - 19h: Khắc 4
        //Từ 7h - 9h và từ 19h - 21h: Khắc 5
        //Từ 9h - 11h và từ 21h - 23h: Khắc 6
        //num = số khắc
        #endregion

        public DataTable GetXuatHanh(DateTime date, int num)
        {
            DataTable dt = GioXuatHanh();
            int k = CongThucTinhGio(date, num);

            DataTable gdt = new DataTable();
            DataColumn column;
            //Tạo cột tên giờ
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            //Tạo cột ý nghĩa
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Mean";
            column.ReadOnly = true;
            column.Unique = true;
            gdt.Columns.Add(column);

            foreach(DataRow row in dt.Rows)
            {
                int numtemp = (Int32)row["num"];
                if(k == numtemp)
                {
                    DataRow grow = gdt.NewRow();
                    grow["Name"] = row["Name"];
                    grow["Mean"] = row["Mean"];
                    gdt.Rows.Add(grow);
                    break;
                }
            }

            return gdt;
        }
        #endregion

        #region Tìm tên ngày hoàng đạo, hắc đạo
        public string GetNameHoangHacDao(DateTime date)
        {
            string s = "";
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            string sChi = GetChiNgay(date);
            int month = luni.Month;

            switch(month)
            {
                case 1:
                    switch(sChi)
                    {
                        case "Tý":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Sửu":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Bạch Hổ Hắc Đạo ";
                            break;
                        case "Sửu":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Sửu":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 8:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 9:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Sửu":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 10:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Sửu":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Thìn":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Tỵ":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Thân":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Dậu":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 11:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Sửu":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Dần":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Mão":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Ngọ":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Mùi":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        case "Tuất":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Hợi":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                case 12:
                    switch (sChi)
                    {
                        case "Tý":
                            s = "Thiên Hình Hắc Đạo";
                            break;
                        case "Sửu":
                            s = "Chu Tước Hắc Đạo";
                            break;
                        case "Dần":
                            s = "Kim Quỹ Hoàng Đạo";
                            break;
                        case "Mão":
                            s = "Kim Đường Hoàng Đạo";
                            break;
                        case "Thìn":
                            s = "Bạch Hổ Hắc Đạo";
                            break;
                        case "Tỵ":
                            s = "Ngọc Đường Hoàng Đạo";
                            break;
                        case "Ngọ":
                            s = "Thiên Lao Hắc Đạo";
                            break;
                        case "Mùi":
                            s = "Nguyên Vu Hắc Đạo";
                            break;
                        case "Thân":
                            s = "Tư Mệnh Hoàng Đạo";
                            break;
                        case "Dậu":
                            s = "Câu Trần Hắc Đạo";
                            break;
                        case "Tuất":
                            s = "Thanh Long Hoàng Đạo";
                            break;
                        case "Hợi":
                            s = "Minh Đường Hoàng Đạo";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }    
            return s;
        }
        #endregion

        #region Tìm Ngũ hành
        public string GetNguHanh(DateTime date)
        {
            string s = "";
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            string sChi = GetChiNgay(date);
            string sCan = GetCanNgay(date);

            int num1 = -1;
            int num2 = -1;

            switch(sCan)
            {
                case "Giáp":
                case "Ất":
                    num1 = 1;
                    break;
                case "Bính":
                case "Đinh":
                    num1 = 2;
                    break;
                case "Mậu":
                case "Kỷ":
                    num1 = 3;
                    break;
                case "Canh":
                case "Tân":
                    num1 = 4;
                    break;
                case "Nhâm":
                case "Quý":
                    num1 = 5;
                    break;
                default:
                    break;
            }    

            switch(sChi)
            {
                case "Tý":
                case "Sửu":
                case "Ngọ":
                case "Mùi":
                    num2 = 0;
                    break;
                case "Dần":
                case "Mão":
                case "Thân":
                case "Dậu":
                    num2 = 1;
                    break;
                case "Thìn":
                case "Tỵ":
                case "Tuất":
                case "Hợi":
                    num2 = 2;
                    break;
                default:
                    break;
            }

            int result = (num1 + num2) % 5;

            switch(result)
            {
                case 0:
                    s = "Mộc";
                    break;
                case 1:
                    s = "Kim";
                    break;
                case 2:
                    s = "Thủy";
                    break;
                case 3:
                    s = "Hỏa";
                    break;
                case 4:
                    s = "Thổ";
                    break;
                default:
                    break;
            }    

            return s;
        }
        #endregion

    }
}
