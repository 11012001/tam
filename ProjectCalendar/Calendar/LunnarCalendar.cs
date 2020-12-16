using System;
using System.Collections.Generic;
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
        public long ChangeDateToJuliusDay(int dd, int mm, int yy)
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

        #region Chuyển từ số ngày Julius thành ngày bình thường (dd/mm/yy)
        public int[] ChangeJuliusDayToDate(long jd)
        {
            long a, b, c, d, e, m;
            int day, month, year;
            // Sau 5/10/1582, lịch Gregorian
            if (jd > 2299160)
            {
                a = jd + 32044;
                b = (int)((4 * a + 3) / 146097.0f);
                c = a - (int)((b * 146097) / 4.0f);
            }
            else
            {
                b = 0;
                c = jd + 32082;
            }
            d = (int)((4 * c + 3) / 1461.0f);
            e = c - (int)((1461 * d) / 4.0f);
            m = (int)((5 * e + 2) / 153.0f);
            day = (int)(e - (int)((153 * m + 2) / 5.0f) + 1);
            month = (int)(m + 3 - 12 * (int)(m / 10.0f));
            year = (int)(b * 100 + d - 4800 + (int)(m / 10.0f));
            return new int[] { day, month, year };
        }
        #endregion

        #region Tính ngày Sóc 
        //Sóc là thời điểm hội diện, đó là khi trái đất, mặt trăng và mặt trời nằm trên một đường thẳng và mặt trăng nằm giữa trái đất và mặt trời.
        //Chu kỳ của điểm Sóc là khoảng 29,5 ngày. Ngày chứa điểm Sóc được gọi là ngày Sóc, và đó là ngày bắt đầu tháng âm lịch.
        public int GetNewMoonDay(int k, int timeZone)
        {
            // T, T2, T3, dr, Jd1, M, Mpr, F, C1, deltat, JdNew;
            var T = k / 1236.85f; // Time in Julian centuries from 1900 January 0.5
            var T2 = T * T;
            var T3 = T2 * T;
            var dr = Math.PI / 180.0f;
            var Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 = Jd1 + 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr); // Mean new moon
            var M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3; // Sun's mean anomaly
            var Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3; // Moon's mean anomaly
            var F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3; // Moon's argument of latitude
            var C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 = C1 - 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));
            double deltat;
            if (T < -11)
            {
                deltat = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            }
            else
            {
                deltat = -0.000278 + 0.000265 * T + 0.000262 * T2;
            };
            var JdNew = Jd1 + C1 - deltat;
            return (int)(JdNew + 0.5 + timeZone / 24.0f);
        }
        #endregion

        #region Tính tọa độ mặt trời tìm Trung Khí
        //Để biết Trung khí nào nằm trong tháng âm lịch nào, ta chỉ cần tính xem mặt trời nằm ở khoảng nào trên đường hoàng đạo vào thời điểm bắt đầu một tháng âm lịch. 
        //Ta chia đường hoàng đạo làm 12 phần và đánh số các cung này từ 0 đến 11: 
        //từ Xuân phân đến Cốc vũ là 0; từ Cốc vũ đến Tiểu mãn là 1; 
        //từ Tiểu mãn đến Hạ chí là 2; v.v.. 
        //Cho jdn là số ngày Julius của bất kỳ một ngày, phương pháp sau này sẽ trả lại số cung nói trên.
        public int GetSunLongitude(double jdn, int timeZone)
        {
            //double T, T2, dr, M, L0, DL, L;
            var T = (jdn - 2451545.5 - timeZone / 24) / 36525; // Time in Julian centuries from 2000-01-01 12:00:00 GMT
            var T2 = T * T;
            var dr = Math.PI / 180; // degree to radian
            var M = 357.52910 + 35999.05030 * T - 0.0001559 * T2 - 0.00000048 * T * T2; // mean anomaly, degree
            var L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T2; // mean longitude, degree
            var DL = (1.914600 - 0.004817 * T - 0.000014 * T2) * Math.Sin(dr * M);
            DL = DL + (0.019993 - 0.000101 * T) * Math.Sin(dr * 2 * M) + 0.000290 * Math.Sin(dr * 3 * M);
            var L = L0 + DL; // true longitude, degree
            L = L * dr;
            L = L - Math.PI * 2 * ((int)(L / (Math.PI * 2))); // Normalize to (0, 2*PI)
            return (int)(L / Math.PI * 6);
        }
        #endregion

        #region Tìm ngày bắt đầu tháng 11 Âm lịch
        //Đông chí thường nằm vào khoảng 19/12-22/12, như vậy trước hết ta tìm ngày Sóc trước ngày 31/12. 
        //Nếu tháng bắt đầu vào ngày đó không chứa Đông chí thì ta phải lùi lại 1 tháng nữa.
        public int GetLunarMonth11(int yy, int timeZone)
        {
            var off = ChangeDateToJuliusDay(31, 12, yy) - 2415021;  // số ngày trước thời điểm 31/12/yy
            var k = (int)(off / 29.530588853);
            var nm = GetNewMoonDay(k, timeZone); // tìm ngày Sóc trước ngày 31/12/yy
            var sunLong = GetSunLongitude(nm, timeZone); // kinh độ mặt trời lúc nửa đêm địa phương
            if (sunLong >= 9) // Nếu tháng bắt đầu vào ngày Sóc đó không có Đông Chí 
            {
                nm = GetNewMoonDay(k - 1, timeZone); // lùi 1 tháng, tính lại ngày Sóc
            }
            return nm;
        }
        #endregion

        #region Xác định tháng Nhuận
        //Nếu giữa hai tháng 11 âm lịch (tức tháng có chứa Đông chí) có 13 tháng âm lịch thì năm âm lịch đó có tháng nhuận. 
        //Để xác định tháng nhuận, ta sử dụng hàm GetSunLongitude như đã nói ở trên. 
        //Cho a11 là ngày bắt đầu tháng 11 âm lịch mà một trong 13 tháng sau đó là tháng nhuận. 
        //Hàm sau cho biết tháng nhuận nằm ở vị trí nào sau tháng 11 này.
        public int GetLeapMonthOffset(long a11, int timeZone)
        {
            int k, last, arc, i;
            k = (int)((a11 - 2415021.076998695) / 29.530588853 + 0.5);
            last = 0;
            i = 1; // Bắt đầu vào tháng tiếp theo tháng 11 âm lịch
            arc = GetSunLongitude(GetNewMoonDay(k + i, timeZone), timeZone);
            do
            {
                last = arc;
                i++;
                arc = GetSunLongitude(GetNewMoonDay(k + i, timeZone), timeZone);
            } while (arc != last && i < 14);
            return i - 1;
        }
        //Giả sử hàm getLeapMonthOffset trả lại giá trị 4, như thế tháng nhuận sẽ là tháng sau tháng 2 thường. 
        //(Tháng thứ 4 sau tháng 11 đáng ra là tháng 3, nhưng vì đó là tháng nhuận nên sẽ lấy tên của tháng trước đó tức tháng 2, 
        //và tháng thứ 5 sau tháng 11 mới là tháng 3).
        #endregion

        #region Đổi ngày Dương lịch sang ngày Âm lịch
        //Trước hết ta xem ngày monthStart bắt đầu tháng âm lịch chứa ngày này là ngày nào (dùng hàm GetNewMoonDay). 
        //Sau đó, ta tìm các ngày a11 và b11 là ngày bắt đầu các tháng 11 âm lịch trước và sau ngày đang xem xét. 
        //Nếu hai ngày này cách nhau dưới 365 ngày thì ta chỉ còn cần xem monthStart và a11 cách nhau bao nhiêu tháng 
        //là có thể tính được dd/mm/yy nằm trong tháng mấy âm lịch. 
        //Ngược lại, nếu a11 và b11 cách nhau khoảng 13 tháng âm lịch thì ta phải tìm xem tháng nào là tháng nhuận 
        //và từ đó suy ra ngày đang tìm nằm trong tháng nào.
        public int[] ConvertSolarDateToLunarDate(int dd, int mm, int yy, int timeZone)
        {
            var dayNumber = ChangeDateToJuliusDay(dd, mm, yy);
            var k = (int)((dayNumber - 2415021.076998695) / 29.530588853);
            var monthStart = GetNewMoonDay(k + 1, timeZone);
            if (monthStart > dayNumber)
            {
                monthStart = GetNewMoonDay(k, timeZone);
            }
            var a11 = GetLunarMonth11(yy, timeZone);
            var b11 = a11;

            int lunarYear;
            if (a11 >= monthStart)
            {
                lunarYear = yy;
                a11 = GetLunarMonth11(yy - 1, timeZone);
            }
            else
            {
                lunarYear = yy + 1;
                b11 = GetLunarMonth11(yy + 1, timeZone);
            }
            var lunarDay = (int)(dayNumber - monthStart + 1);
            var diff = (int)((monthStart - a11) / 29);
            var lunarLeap = 0;
            var lunarMonth = diff + 11;
            if (b11 - a11 > 365)
            {
                var leapMonthDiff = GetLeapMonthOffset(a11, timeZone) - 1;
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = diff + 10;
                    if (diff == leapMonthDiff)
                    {
                        lunarLeap = 1;
                    }
                }
            }
            if (lunarMonth > 12)
            {
                lunarMonth = lunarMonth - 12;
            }
            if (lunarMonth >= 11 && diff < 4)
            {
                lunarYear -= 1;
            }
            
            return new int[] { lunarDay, lunarMonth, lunarYear,lunarLeap };
        }

        public int GetLeapMonth(int yy, int timeZone)
        {
            int dd = 29, mm = 12;
            var dayNumber = ChangeDateToJuliusDay(dd, mm, yy);
            var k = (int)((dayNumber - 2415021.076998695) / 29.530588853);
            var monthStart = GetNewMoonDay(k + 1, timeZone);
            if (monthStart > dayNumber)
            {
                monthStart = GetNewMoonDay(k, timeZone);
            }
            var a11 = GetLunarMonth11(yy, timeZone);
            var b11 = a11;
            if (a11 >= monthStart)
            {
                a11 = GetLunarMonth11(yy - 1, timeZone);
            }
            else
            {
                b11 = GetLunarMonth11(yy + 1, timeZone);
            }
            var diff = (int)((monthStart - a11) / 29);
            var lunarMonth = diff + 11;
            if (b11 - a11 > 365)
            {
                var leapMonthDiff = GetLeapMonthOffset(a11, timeZone) - 1;
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = leapMonthDiff + 10;
                        if (lunarMonth > 12)
                        {
                            lunarMonth = lunarMonth - 12;
                        }
                        return lunarMonth;
                }
            }
            return 0;
        }
        #endregion

        #region Đổi ngày Âm lịch sang ngày Dương lịch
        //Cách làm cũng tương tự như đổi ngày dương sang ngày âm.
        public int[] ConvertLunarDateToSolarDate(int lunarDay, int lunarMonth, int lunarYear, int lunarLeap, int timeZone)
        {
            int k, off, leapOff;
            long a11, b11, leapMonth, monthStart;
            if (lunarMonth < 11)
            {
                a11 = GetLunarMonth11(lunarYear - 1, timeZone);
                b11 = GetLunarMonth11(lunarYear, timeZone);
            }
            else
            {
                a11 = GetLunarMonth11(lunarYear, timeZone);
                b11 = GetLunarMonth11(lunarYear + 1, timeZone);
            }
            off = lunarMonth - 11;
            if (off < 0)
            {
                off += 12;
            }
            if (b11 - a11 > 365)
            {
                leapOff = GetLeapMonthOffset(a11, timeZone) - 1;
                leapMonth = leapOff - 2;
                if (leapMonth < 0)
                {
                    leapMonth += 12;
                }
                if (lunarLeap != 0 && lunarMonth != leapMonth)
                {
                    return new int[] { 0, 0, 0 };
                }
                else if (lunarLeap != 0 || off >= leapOff)
                {
                    off += 1;
                }
            }
            k = (int)(0.5 + (a11 - 2415021.076998695) / 29.530588853);
            monthStart = GetNewMoonDay(k + off, timeZone);
            return ChangeJuliusDayToDate(monthStart + lunarDay - 1);
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
        public int GetSolarMonth(int dd,int mm, int yy)
        {
            int[] nums = ConvertLunarDateToSolarDate(dd, mm, yy, 0, 7);
            return nums[1];
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
                saveTmp = "Tý (23-1), Sửu (1-3), Thìn (7-9), Tỵ (9-11), Mùi (13-15), Tuất (19-21)";
            if (dayChi.Equals("mão", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("dậu", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23-1), Dần (3-5), Mão (5-7), Ngọ (11-13), Mùi (13-15), Dậu (17-19)";
            if (dayChi.Equals("thìn", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("tuất", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3-5), Thìn (7-9), Tỵ (9-11), Thân (15-17), Dậu (17-19), Hợi (21-23)";
            if (dayChi.Equals("tỵ", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("hợi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Sửu (1-3), Thìn (7-9), Ngọ (11-13), Mùi (13-15), Tuất (19-21), Hợi (21-23)";
            if (dayChi.Equals("tý", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("ngọ", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Tý (23-1), Sửu (1-3), Mão (5-7), Ngọ (11-13), Thân (15-17), Dậu (17-19)";
            if (dayChi.Equals("sửu", StringComparison.OrdinalIgnoreCase) || dayChi.Equals("mùi", StringComparison.OrdinalIgnoreCase))
                saveTmp = "Dần (3-5), Mão (5-7), Tỵ (9-11), Thân (15-17), Tuất (19-21), Hợi (21-23)";
            return saveTmp;
        }
        public String GetZodiacTimeSmallVersion(DateTime date)
        {
            String dayChi = GetChiNgay(date);
            String saveTmp = "";

            if (dayChi == "Dần" || dayChi == "Thân")
                saveTmp = "Tý,Sửu,Thìn,Tỵ,Mùi,Tuất";
            if (dayChi == "Mão" || dayChi == "Dậu" )
                saveTmp = "Tý,Dần,Mão,Ngọ,Mùi,Dậu";
            if (dayChi == "Thìn" || dayChi == "Tuất" )
                saveTmp = "Dần,Thìn,Tỵ,Thân,Dậu,Hợi";
            if (dayChi == "Tỵ" || dayChi == "Hợi")
                saveTmp = "Sửu,Thìn,Ngọ,Mùi,Tuất,Hợi";
            if (dayChi == "Tý" || dayChi == "Ngọ")
                saveTmp = "Tý,Sửu,Mão,Ngọ,Thân,Dậu";
            if (dayChi == "Sửu" || dayChi == "Mùi")
                saveTmp = "Dần,Mão,Tỵ,Thân,Tuất,Hợi";
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
        public int IsZodiacDay(DateTime date,int lunnarmonth)
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
            switch(hour)
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
    }
}
