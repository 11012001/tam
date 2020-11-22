using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarNum1
{
    class SolarEvent
    {
        public static List<string> GetEventMonth(DateTime date)
        {
            List<string> Ls = new List<string>();
            if (date.Month == 1)
            {
                Ls.Add("Tết Dương lịch");
                Ls.Add("Ngày Học sinh – Sinh viên Việt Nam");
            }
            else if (date.Month == 2)
            {
                Ls.Add("Ngày thành lập Đảng Cộng sản Việt Nam");
                Ls.Add("Lễ tình nhân (Valentine)");
                Ls.Add("Ngày thầy thuốc Việt Nam");
            }
            else if (date.Month == 3)
            {
                Ls.Add("Ngày Quốc tế Phụ nữ");
                Ls.Add("Ngày Quốc tế Hạnh phúc");
                Ls.Add("Ngày Nước sạch Thế giới");
                Ls.Add("Ngày thành lập Đoàn TNCS Hồ Chí Minh");
                Ls.Add("Ngày Thể thao Việt Nam");
                Ls.Add("Ngày thành lập lực lượng Dân quân tự vệ");
            }
            else if (date.Month == 4)
            {
                Ls.Add("Ngày Cá tháng Tư");
                Ls.Add("Ngày Trái đất");
                Ls.Add("Ngày Sách Việt Nam");
                Ls.Add("Ngày giải phóng miền Nam");
            }
            else if (date.Month == 5)
            {
                Ls.Add("Ngày Quốc tế Lao động");
                Ls.Add("Ngày chiến thắng Điện Biên Phủ");
                Ls.Add("Ngày của mẹ");
                Ls.Add("Ngày thành lập Đội Thiếu niên Tiền phong Hồ Chí Minh");
                Ls.Add("Ngày sinh chủ tịch Hồ Chí Minh");
            }
            else if (date.Month == 6)
            {
                Ls.Add("Ngày Quốc tế thiếu nhi");
                Ls.Add("Ngày Bác Hồ ra đi tìm đường cứu nước  và Ngày môi trường thế giới");
                Ls.Add("Ngày của cha");
                Ls.Add("Ngày báo chí Việt Nam");
                Ls.Add("Ngày gia đình Việt Nam");
            }
            else if (date.Month == 7)
            {
                Ls.Add("Ngày dân số thế giới");
                Ls.Add("Ngày Thương binh liệt sĩ");
                Ls.Add("Ngày thành lập công đoàn Việt Nam");
            }
            else if (date.Month == 8)
            {
                Ls.Add("Ngày tổng khởi nghĩa, Ngày Cách mạng tháng Tám thành công");
            }
            else if (date.Month == 9)
            {
                Ls.Add("Ngày Quốc Khánh");
                Ls.Add("Ngày thành lập Đài Truyền hình Việt Nam");
                Ls.Add("Ngày thành lập Mặt trận Tổ quốc Việt Nam");
            }
            else if (date.Month == 10)
            {
                Ls.Add("Ngày quốc tế người cao tuổi");
                Ls.Add("Ngày giải phóng thủ đô");
                Ls.Add("Ngày doanh nhân Việt Nam");
                Ls.Add("Ngày thành lập Hội Nông dân Việt Nam");
                Ls.Add("Ngày Phụ nữ Việt Nam và cũng là Ngày thành lập Hội Phụ nữ Việt Nam");
                Ls.Add("Ngày Hallowen");
            }
            else if (date.Month == 11)
            {
                Ls.Add("Ngày pháp luật Việt Nam");
                Ls.Add("Ngày Nhà giáo Việt Nam");
                Ls.Add("Ngày thành lập Hội chữ thập đỏ Việt Nam");
            }
            else
            {
                Ls.Add("Ngày thế giới phòng chống AIDS");
                Ls.Add("Ngày toàn quốc kháng chiến");
                Ls.Add("Ngày thành lập quân đội nhân dân Việt Nam");
                Ls.Add("Ngày lễ Giáng sinh");
                Ls.Add("Lễ Giáng sinh");
            }

            //Sự kiện lịch âm
            LunnarCalendar lunnarCalendar = new LunnarCalendar();
            if (lunnarCalendar.GetSolarMonth(23, 12, date.Year - 1) == date.Month)
            {
                Ls.Add("Tiễn Táo Quân về trời");
            }
            int[] nums = lunnarCalendar.ConvertLunarDateToSolarDate(30, 12, date.Year - 1, 0, 7);
            int[] nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, date.Year, 0, 7);
            if ((nums[0] == nums1[0]) && (nums[1] == nums1[1]) && (nums[2] == nums1[2]))
            {
                if (lunnarCalendar.GetSolarMonth(29, 12, date.Year - 1) == date.Month)
                {
                    Ls.Add("Tết Nguyên Đán - Đêm giao thừa");
                }
            }
            else
            {
                if (lunnarCalendar.GetSolarMonth(30, 12, date.Year - 1) == date.Month)
                {
                    Ls.Add("Tết Nguyên Đán - Đêm giao thừa");
                }
            }
            
            if (lunnarCalendar.GetSolarMonth(1, 1, date.Year) == date.Month)
            {             
                Ls.Add("Tết Nguyên Đán - Mùng 1 ");
            }
            if (lunnarCalendar.GetSolarMonth(2, 1, date.Year) == date.Month)
            {
                Ls.Add("Tết Nguyên Đán - Mùng 2 ");
            }
            if (lunnarCalendar.GetSolarMonth(3, 1, date.Year) == date.Month)
            {
                Ls.Add("Tết Nguyên Đán - Mùng 3 ");
            }
            if (lunnarCalendar.GetSolarMonth(15, 1, date.Year) == date.Month)
            {
                Ls.Add("Tết Nguyên Tiêu (Lễ Thượng Nguyên)");
            }
            if (lunnarCalendar.GetSolarMonth(3, 3, date.Year) == date.Month)
            {
                Ls.Add("Tết Hàn Thực");
            }
            if (lunnarCalendar.GetSolarMonth(10, 3, date.Year) == date.Month)
            {
                Ls.Add("Giỗ Tổ Hùng Vương");
            }
            if (lunnarCalendar.GetSolarMonth(15, 4, date.Year) == date.Month)
            {
                Ls.Add("Lễ Phật Đảng");
            }
            if (lunnarCalendar.GetSolarMonth(5, 5, date.Year) == date.Month)
            {
                Ls.Add("Tết Đoan Ngọ");
            }
            if (lunnarCalendar.GetSolarMonth(15, 7, date.Year) == date.Month)
            {
                Ls.Add("Lễ Vu Lan");
            }
            if (lunnarCalendar.GetSolarMonth(15, 8, date.Year) == date.Month)
            {
                Ls.Add("Tết Trung Thu");
            }
            if (lunnarCalendar.GetSolarMonth(9, 9, date.Year) == date.Month)
            {
                Ls.Add("Tết Trùng Cửu");
            }
            if (lunnarCalendar.GetSolarMonth(10, 10, date.Year) == date.Month)
            {
                Ls.Add("Tết Thường Tân");
            }
            if (lunnarCalendar.GetSolarMonth(15, 10, date.Year) == date.Month)
            {
                Ls.Add("Tết Hạ Nguyên");
            }
            
            
            return Ls;
        }

        public static List<DateTime> GetEventDateMonth(DateTime date)
        {
            List<DateTime> lDt = new List<DateTime>();
            if (date.Month == 1)
            {
                lDt.Add(new DateTime(date.Year, 1, 1));
                lDt.Add(new DateTime(date.Year, 1, 9));
            }
            else if (date.Month == 2)
            {
                lDt.Add(new DateTime(date.Year, 2, 3));
                lDt.Add(new DateTime(date.Year, 2, 14));
                lDt.Add(new DateTime(date.Year, 2, 27));
            }
            else if (date.Month == 3)
            {
                lDt.Add(new DateTime(date.Year, 3, 8));
                lDt.Add(new DateTime(date.Year, 3, 20));
                lDt.Add(new DateTime(date.Year, 3, 22));
                lDt.Add(new DateTime(date.Year, 3, 26));
                lDt.Add(new DateTime(date.Year, 3, 27));
                lDt.Add(new DateTime(date.Year, 3, 28));
            }
            else if (date.Month == 4)
            {
                lDt.Add(new DateTime(date.Year, 4, 1));
                lDt.Add(new DateTime(date.Year, 4, 22));
                lDt.Add(new DateTime(date.Year, 4, 23));
                lDt.Add(new DateTime(date.Year, 4, 30));
            }
            else if (date.Month == 5)
            {
                lDt.Add(new DateTime(date.Year, 5, 1));
                lDt.Add(new DateTime(date.Year, 5, 7));
                lDt.Add(new DateTime(date.Year, 5, 13));
                lDt.Add(new DateTime(date.Year, 5, 15));
                lDt.Add(new DateTime(date.Year, 5, 19));
            }
            else if (date.Month == 6)
            {
                lDt.Add(new DateTime(date.Year, 6, 1));
                lDt.Add(new DateTime(date.Year, 6, 5));
                lDt.Add(new DateTime(date.Year, 6, 17));
                lDt.Add(new DateTime(date.Year, 6, 21));
                lDt.Add(new DateTime(date.Year, 6, 28));
            }
            else if (date.Month == 7)
            {
                lDt.Add(new DateTime(date.Year, 7, 11));
                lDt.Add(new DateTime(date.Year, 7, 27));
                lDt.Add(new DateTime(date.Year, 7, 28));
            }
            else if (date.Month == 8)
            {
                lDt.Add(new DateTime(date.Year, 8, 19));
            }
            else if (date.Month == 9)
            {
                lDt.Add(new DateTime(date.Year, 9, 2));
                lDt.Add(new DateTime(date.Year, 9, 7));
                lDt.Add(new DateTime(date.Year, 9, 10));
            }
            else if (date.Month == 10)
            {
                lDt.Add(new DateTime(date.Year, 10, 1));
                lDt.Add(new DateTime(date.Year, 10, 10));
                lDt.Add(new DateTime(date.Year, 10, 13));
                lDt.Add(new DateTime(date.Year, 10, 14));
                lDt.Add(new DateTime(date.Year, 10, 20));
                lDt.Add(new DateTime(date.Year, 10, 31));
            }
            else if (date.Month == 11)
            {
                lDt.Add(new DateTime(date.Year, 11, 9));
                lDt.Add(new DateTime(date.Year, 11, 20));
                lDt.Add(new DateTime(date.Year, 11, 23));
            }
            else
            {
                lDt.Add(new DateTime(date.Year, 12, 1));
                lDt.Add(new DateTime(date.Year, 12, 19));
                lDt.Add(new DateTime(date.Year, 12, 22));
                lDt.Add(new DateTime(date.Year, 12, 24));
                lDt.Add(new DateTime(date.Year, 12, 25));
            }

            LunnarCalendar lunnarCalendar = new LunnarCalendar();
            int[] nums = new int[3];
            if (lunnarCalendar.GetSolarMonth(23, 12, date.Year - 1) == date.Month)
            {
                 nums = lunnarCalendar.ConvertLunarDateToSolarDate(23, 12, date.Year - 1, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            nums = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, date.Year, 0, 7);
            int[] nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(30, 12, date.Year - 1, 0, 7);
            if((nums[0] == nums1[0]) && (nums[1] == nums1[1]) && (nums[2] == nums1[2]))
            {
                if (lunnarCalendar.GetSolarMonth(29, 12, date.Year - 1) == date.Month)
                {
                    nums = lunnarCalendar.ConvertLunarDateToSolarDate(29, 12, date.Year - 1, 0, 7);
                    lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
                }
            }
            else
            {
                if (lunnarCalendar.GetSolarMonth(30, 12, date.Year - 1) == date.Month)
                {
                    nums = lunnarCalendar.ConvertLunarDateToSolarDate(30, 12, date.Year - 1, 0, 7);
                    lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
                }
            }
            if (lunnarCalendar.GetSolarMonth(1, 1, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, date.Year, 0, 7);               
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(2, 1, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(2, 1, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(3, 1, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(3, 1, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(15, 1, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(15, 1, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(3, 3, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(3, 3, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(10, 3, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(10, 3, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(15, 4, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(15, 4, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(5, 5, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(5, 5, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(15, 7, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(15, 7, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(15, 8, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(15, 8, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(9, 9, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(9, 9, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(10, 10, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(10, 10, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
            if (lunnarCalendar.GetSolarMonth(15, 10, date.Year) == date.Month)
            {
                nums = lunnarCalendar.ConvertLunarDateToSolarDate(15, 10, date.Year, 0, 7);
                lDt.Add(new DateTime(nums[2], nums[1], nums[0]));
            }
           
            return lDt;
        }
        public static int DayOfMonth(int month,int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        return 29;
                    return 28;
                default:
                    return 30;
            }
        }
    }
}
