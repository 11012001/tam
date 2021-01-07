using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;

namespace LunnarSample
{
    class PublicDate
    {
        public static DataTable TableDate(int year)
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            //Tạo cột đầu tiên
            column = new DataColumn();
            column.DataType = Type.GetType("System.DateTime");
            column.ColumnName = "Date";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột thứ hai
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Event";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            //Tạo cột thứ ba            
            column = new DataColumn();
            column.DataType = Type.GetType("System.Boolean");
            column.ColumnName = "Important";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            #region Thêm dữ liệu vào DataTable

            #region Ngày Âm Lịch
            LuniSolarDate<VietnameseLocalInfoProvider> luni;

            #region 1/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 1);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Đán - Mùng 1");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 2/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 2);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Đán - Mùng 2");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 3/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 3);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Đán - Mùng 3");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 4/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 4);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Đán - Mùng 4");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 5/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 5);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Đán - Mùng 5");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 5/1 AL (LS)
            if(year >= 1789)
            {
                row = dt.NewRow();
                luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 5);
                row["Date"] = luni.SolarDate;
                row["Event"] = string.Format("Chiến Thắng Ngọc Hồi - Đống Đa(1789)");
                row["Important"] = true;
                dt.Rows.Add(row);
            }
            #endregion

            #region 15/1 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 15);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Nguyên Tiêu");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 3/3 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 3, false, 3);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Hàn Thực");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 10/3 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 3, false, 10);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Giỗ Tổ Hùng Vương");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 14/4 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 4, false, 14);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Dân tộc Khmer");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 15/4 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 4, false, 15);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Lễ Phật Đản");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 5/5 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 5, false, 5);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Đoan Ngọ");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 15/7 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 7, false, 15);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Lễ Vu Lan/Lễ Xá Tội Vong Nhân");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/8 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 8, false, 1);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Lễ Hội Katé");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 15/8 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 8, false, 15);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Trung Thu");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 9/9 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 9, false, 9);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Trùng Cửu");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 10/10 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 10, false, 10);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Tết Trùng Thập");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 23/12 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year - 1, 12, false, 23);
            row["Date"] = luni.SolarDate;
            row["Event"] = string.Format("Ngày Ông Táo Về Trời");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 30/12 AL
            row = dt.NewRow();
            luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, 1, false, 1);
            row["Date"] = luni.SolarDate.AddDays(-1);
            row["Event"] = string.Format("Tết Nguyên Đán - Đêm Giao thừa");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #endregion

            #region Ngày Dương Lịch

            #region 1/1
            row = dt.NewRow();
            row["Date"] = new DateTime(0002, 01, 01);
            row["Event"] =string.Format("Tết Dương Lịch");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 9/1
            row = dt.NewRow();
            row["Date"] = new DateTime(1950, 01, 09);
            row["Event"] = string.Format("Ngày Truyền Thống Học Sinh, Sinh Viên Việt Nam(1950)");
            row["Important"] = false;
            dt.Rows.Add(row);            
            #endregion

            #region 11/1
            row = dt.NewRow();
            row["Date"] = new DateTime(2007, 01, 11);
            row["Event"] = string.Format("Ngày Việt Nam Gia Nhập WTO(2007)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 3/2
            row = dt.NewRow();
            row["Date"] = new DateTime(1930, 02, 03);
            row["Event"] = string.Format("Ngày Thành Lập Đảng Cộng Sản Việt Nam(1930)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 14/2
            row = dt.NewRow();
            row["Date"] = new DateTime(0269, 02, 14);
            row["Event"] = string.Format("Ngày Lễ Tình Yêu");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 27/2
            row = dt.NewRow();
            row["Date"] = new DateTime(1955, 02, 27);
            row["Event"] = string.Format("Ngày Thầy Thuốc Việt Nam(1955)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 3/3
            row = dt.NewRow();
            row["Date"] = new DateTime(2014, 03, 03);
            row["Event"] = string.Format("Ngày Sinh Giới Hoang Dã Thế giới(2014)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 8/3
            row = dt.NewRow();
            row["Date"] = new DateTime(1910, 03, 08);
            row["Event"] = string.Format("Ngày Quốc Tế Phụ Nữ");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 20/3
            row = dt.NewRow();
            row["Date"] = new DateTime(2013, 03, 20);
            row["Event"] = string.Format("Ngày Quốc Tế Hạnh Phúc(2013)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 22/3
            row = dt.NewRow();
            row["Date"] = new DateTime(1993, 03, 22);
            row["Event"] = string.Format("Ngày Nước Sạch Thế Giới(1993)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 26/3
            row = dt.NewRow();
            row["Date"] = new DateTime(1931, 03, 26);
            row["Event"] = string.Format("Ngày Thành Lập Đoàn TNCS Hồ Chí Minh(1931)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 27/3
            row = dt.NewRow();
            row["Date"] = new DateTime(1946, 03, 27);
            row["Event"] = string.Format("Ngày Thể Thao Việt Nam(1946)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 28/3
            row = dt.NewRow();
            row["Date"] = new DateTime(1935,03,28);
            row["Event"] = string.Format("Ngày Thành Lập Lực Lượng Dân Quân Tự Vệ(1935)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/4
            row = dt.NewRow();
            row["Date"] = new DateTime(1582, 04, 01);
            row["Event"] = string.Format("Ngày Cá Tháng Tư");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 21/4
            row = dt.NewRow();
            row["Date"] = new DateTime(2014, 04, 21);
            row["Event"] = string.Format("Ngày Sách Việt Nam(2014)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 30/4
            row = dt.NewRow();
            row["Date"] = new DateTime(1975, 04, 30);
            row["Event"] = string.Format("Ngày Giải Phóng Miền Nam Thống Nhất Đất Nước");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 1/5
            row = dt.NewRow();
            row["Date"] = new DateTime(1886, 05, 01);
            row["Event"] = string.Format("Ngày Quốc Tế Lao Động");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 7/5
            row = dt.NewRow();
            row["Date"] = new DateTime(1954, 05, 07);
            row["Event"] = string.Format("Ngày Chiến Thắng Điện Biên Phủ(1954)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 15/5
            row = dt.NewRow();
            row["Date"] = new DateTime(1941,05,15);
            row["Event"] = string.Format("Ngày thành Lập Đội Thiếu Niên Tiền Phong Hồ Chí Minh(1941)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 19/5
            row = dt.NewRow();
            row["Date"] = new DateTime(1890, 05, 19);
            row["Event"] = string.Format("Ngày Sinh Của Chủ Tịch Hồ Chí Minh(1890)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/6
            row = dt.NewRow();
            row["Date"] = new DateTime(1925, 06, 01);
            row["Event"] = string.Format("Ngày Quốc Tế Thiếu Nhi");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 5/6
            row = dt.NewRow();
            row["Date"] = new DateTime(1911, 06, 05);
            row["Event"] = string.Format("Ngày Bác Hồ Ra Đi Tìm Đường Cứu Nước(1911)");
            row["Important"] = false;
            dt.Rows.Add(row);
            row = dt.NewRow();
            row["Date"] = new DateTime(1972, 06, 05);
            row["Event"] = string.Format("Ngày Môi trường Thế Giới(1972)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 21/6
            row = dt.NewRow();
            row["Date"] = new DateTime(1925, 06, 21);
            row["Event"] = string.Format("Ngày Báo Chí Việt Nam(1925)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 28/6
            row = dt.NewRow();
            row["Date"] = new DateTime(2001, 06, 28);
            row["Event"] = string.Format("Ngày Gia Đình Việt Nam(2001)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 27/7
            row = dt.NewRow();
            row["Date"] = new DateTime(1955, 07, 27);
            row["Event"] = string.Format("Ngày Thương Binh Liệt Sĩ(1955)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 28/7
            row = dt.NewRow();
            row["Date"] = new DateTime(1929, 07, 28);
            row["Event"] = string.Format("Ngày Thành Lập Công Đoàn Việt Nam(1929)");
            row["Important"] = false;
            dt.Rows.Add(row);
            row = dt.NewRow();
            row["Date"] = new DateTime(1995, 07, 28);
            row["Event"] = string.Format("Ngày Việt Nam Gia Nhập ASSEAN(1995)"); 
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/8
            row = dt.NewRow();
            row["Date"] = new DateTime(1930, 08, 01);
            row["Event"] = string.Format("Ngày Truyền Thống Công Tác Tư Tưởng – Văn Hoá Của Đảng(1930)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 10/8
            row = dt.NewRow();
            row["Date"] = new DateTime(2009, 08, 10);
            row["Event"] = string.Format("Ngày Vì Nạn Nhân Chất Độc Màu Da Cam Việt Nam (2009)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 12/8
            row = dt.NewRow();
            row["Date"] = new DateTime(1999, 08, 12);
            row["Event"] = string.Format("Ngày Quốc Tế Thanh Thiếu Niên(1999)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 19/8
            row = dt.NewRow();
            row["Date"] = new DateTime(1945, 08, 19);
            row["Event"] = string.Format("Ngày Cách Mạng Tháng Tám Thành Công(1945) và Ngày Truyền Thống Lực Lượng Công An Nhân Dân(1945)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 2/9
            row = dt.NewRow();
            row["Date"] = new DateTime(1945, 09, 02);
            row["Event"] = string.Format("Ngày Quốc Khánh Nước Cộng Hoà Xã Hội Chủ Nghĩa Việt Nam");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 7/9
            row = dt.NewRow();
            row["Date"] = new DateTime(1970, 09, 07);
            row["Event"] = string.Format("Ngày Thành Lập Đài Truyền Hình Việt Nam(1970)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 10/9
            row = dt.NewRow();
            row["Date"] = new DateTime(1955, 09, 10);
            row["Event"] = string.Format("Ngày Thành Lập Mặt Trận Tổ Quốc Việt Nam(1955)"); 
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 20/9
            row = dt.NewRow();
            row["Date"] = new DateTime(1977, 09, 20);
            row["Event"] = string.Format("Ngày Việt Nam Trở Thành Thành Viên Liên Hiệp Quốc(1977)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 21/9
            row = dt.NewRow();
            row["Date"] = new DateTime(1981, 09, 21);
            row["Event"] = string.Format("Ngày Quốc Tế Hòa Bình(1981)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/10
            row = dt.NewRow();
            row["Date"] = new DateTime(1991, 10, 01);
            row["Event"] = string.Format("Ngày Quốc Tế Người Cao Tuổi(1991)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 10/10
            row = dt.NewRow();
            row["Date"] = new DateTime(1954, 10, 10);
            row["Event"] = string.Format("Ngày Giải Phóng Thủ Đô(1954)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 14/10
            row = dt.NewRow();
            row["Date"] = new DateTime(1930, 10, 14);
            row["Event"] = string.Format("Ngày Thành Lập Hội Nông Dân Việt Nam(1930)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 15/10
            row = dt.NewRow();
            row["Date"] = new DateTime(1956, 10, 15);
            row["Event"] = string.Format("Ngày Truyền Thống Hội Liên Hiệp Thanh Niên Việt Nam(1956)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 20/10
            row = dt.NewRow();
            row["Date"] = new DateTime(1930, 10, 20);
            row["Event"] = string.Format("Ngày Phụ Nữ Việt Nam(1930)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 23/10
            row = dt.NewRow();
            row["Date"] = new DateTime(2004, 10, 13);
            row["Event"] = string.Format("Ngày Doanh Nhân Việt Nam(2004)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 31/10
            row = dt.NewRow();
            row["Date"] = new DateTime(0001,10, 31);
            row["Event"] = string.Format("Ngày Lễ Halloween");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 9/11
            row = dt.NewRow();
            row["Date"] = new DateTime(2012, 09, 11);
            row["Event"] = string.Format("Ngày Pháp Luật Việt Nam(2012)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 20/11
            row = dt.NewRow();
            row["Date"] = new DateTime(1958, 11, 20);
            row["Event"] = string.Format("Ngày Nhà Giáo Việt Nam(1958)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 23/11
            row = dt.NewRow();
            row["Date"] = new DateTime(1946, 11, 23);
            row["Event"] = string.Format("Ngày Thành Lập Hội Chữ Thập Đỏ Việt Nam(1946)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 1/12
            row = dt.NewRow();
            row["Date"] = new DateTime(1988, 12, 01);
            row["Event"] = string.Format("Ngày Thế Giới Phòng Chống AIDS(1988)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 19/12
            row = dt.NewRow();
            row["Date"] = new DateTime(1946, 12, 19);
            row["Event"] = string.Format("Ngày Toàn Quốc Kháng Chiến(1946)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 22/12
            row = dt.NewRow();
            row["Date"] = new DateTime(1944, 12, 22);
            row["Event"] = string.Format("Ngày Thành Lập Quân Đội Nhân Dân Việt Nam(1944)");
            row["Important"] = false;
            dt.Rows.Add(row);
            #endregion

            #region 24/12
            row = dt.NewRow();
            row["Date"] = new DateTime(0001, 12, 24);
            row["Event"] = string.Format("Đêm Vọng Lễ Giáng Sinh");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 25/12
            row = dt.NewRow();
            row["Date"] = new DateTime(0001, 12, 25);
            row["Event"] = string.Format("Ngày Lễ Giáng Sinh");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #region 31/12
            row = dt.NewRow();
            row["Date"] = new DateTime(0002, 12, 31);
            row["Event"] = string.Format("Đêm Giao thừa");
            row["Important"] = true;
            dt.Rows.Add(row);
            #endregion

            #endregion


            #endregion

            return dt;
        }

        public static DateTime FatherDate(int year)
        {
            DateTime date = new DateTime(1,1,1);
            if (year >= 1972)
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 30; day++)
                {
                    DateTime dt = new DateTime(year, 6, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 3)
                    {
                        sunday = day;
                        break;
                    }
                }
               date = new DateTime(year, 6, sunday);
            }
            return date;
        }
        public static DateTime MotherDate(int year)
        {
            DateTime date = new DateTime(1, 1, 1);
            if(year >= 1914)
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 31; day++)
                {
                    DateTime dt = new DateTime(year, 5, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 2)
                    {
                        sunday = day;
                        break;
                    }
                }
                date = new DateTime(year, 5, sunday);
            }
            return date;
        }


        //Kiểm tra ngày đó có phải ngày lễ hay không (1 lễ nghỉ, 0 lễ, -1 không phải lễ)
        public static int[] IsPublic(DateTime date)
        {
            int[] ispublics = new int[3] { -1, -1, -1 };
            int i = 0;


            //Ngày của Cha
            if ((date.Month == 6)  && (date.Year >= 1972))
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 30; day++)
                {
                    DateTime dt = new DateTime(date.Year, 6, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 3)
                    {
                        sunday = day;
                        break;
                    }
                }
                if (date.Day == sunday)
                {
                    ispublics[0] = 0;
                    i++;
                }
            }
            //Ngày của mẹ
            else if((date.Month == 5) && (date.Year >= 1914))
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 30; day++)
                {
                    DateTime dt = new DateTime(date.Year, 5, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 2)
                    {
                        sunday = day;
                        break;
                    }
                }
                if (date.Day == sunday)
                {
                    ispublics[0] = 0;
                    i++;
                }
            }

            foreach (DataRow row in PublicDate.TableDate(date.Year).Rows)
            {
                DateTime daterow = (DateTime)row["Date"];
                if ((date.Day == daterow.Day) && (date.Month == daterow.Month) && (date.Year >= daterow.Year))
                {
                    bool holidays = (bool)row["Important"];
                    if (holidays == true)
                    {
                        if (ispublics[0] == -1)
                        {
                            ispublics[0] = 1;
                            i++;
                        }
                        else if (ispublics[1] == -1)
                        {
                            ispublics[1] = 1;
                            i++;
                        }
                        else
                        {
                            ispublics[2] = 1;
                            i++;
                        }
                    }
                    else
                    {
                        if (ispublics[0] == -1)
                        {
                            ispublics[0] = 0;
                            i++;
                        }
                        else if (ispublics[1] == -1)
                        {
                            ispublics[1] = 0;
                            i++;
                        }
                        else
                        {
                            ispublics[2] = 0;
                            i++;
                        }
                    }
                }
            }
            if(i == 0)
            {
                int[] arrint = new int[1] { -1 };
                return arrint;
            }
            else
            {
                int[] arrint = new int[i];
                for(int k = 0;k<i;k++)
                {
                    arrint[k] = ispublics[k];
                }
                return arrint;
            }
        }

        //Tìm tên của ngày lễ đó
        public static string[] IsPublicString(DateTime date)
        {
            string[] events = new string[3] { "", "", "" };
            int i = 0;
            //Ngày của Cha
            if (date.Month == 6)
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 30; day++)
                {
                    DateTime dt = new DateTime(date.Year, 6, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 3)
                    { 
                        sunday = day;
                        break;
                    }
                }
                if (date.Day == sunday)
                {
                    events[0] = "Ngày Của Cha";
                    i++;
                }
            }
            //Ngày của mẹ
            else if (date.Month == 5)
            {
                int sunday = 0;
                int count = 0;
                for (int day = 1; day <= 31; day++)
                {
                    DateTime dt = new DateTime(date.Year, 5, day);
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        count++;
                    if (count == 2)
                    {
                        sunday = day;
                        break;
                    }
                }
                if (date.Day == sunday)
                {
                    events[0] = "Ngày Của Mẹ";
                    i++;
                }
            }

            foreach (DataRow row in PublicDate.TableDate(date.Year).Rows)
            {
                DateTime daterow = (DateTime)row["Date"];
                if ((date.Day == daterow.Day) && (date.Month == daterow.Month) && (date.Year >= daterow.Year))
                {
                    String name = (string)row["Event"];
                    if(events[0] == "")
                    {
                        events[0] = name;
                        i++;
                    }
                    else if(events[1] == "")
                    {
                        events[1] = name;
                        i++;
                    }
                    else
                    {
                        events[2] = name;
                        i++;
                    }
                }
            }
            if(i== 0)
            {
                string[] arr = new string[1] { "" };
                return arr;
            }
            else
            {
                string[] arr = new string[i];
                for (int k = 0; k < i; k++)
                {
                    arr[k] = events[k];
                }
                return arr;
            }
        }

        public static DateTime IsPublicDate(string s,int year)
        {
            foreach(DataRow row in PublicDate.TableDate(year).Rows)
            {
                string name = (string)row["Event"];
                DateTime date = (DateTime)row["Date"];
                if (s == name)
                    return date;
            }
            if(s == "Ngày Của Cha")
            {
                DateTime date = FatherDate(year);
                if((date.Day == 1) && (date.Month == 1) &&(date.Year == 1))
                {
                    return new DateTime(1, 1, 1);
                }
                else
                {
                    return date;
                }
            }
            else if (s == "Ngày Của Mẹ")
            {
                DateTime date = MotherDate(year);
                if ((date.Day == 1) && (date.Month == 1) && (date.Year == 1))
                {
                    return new DateTime(1, 1, 1);
                }
                else
                {
                    return date;
                }
            }
            return new DateTime(1,1,1);
        }
    }
}
