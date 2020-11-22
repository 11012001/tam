using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

    }
}
