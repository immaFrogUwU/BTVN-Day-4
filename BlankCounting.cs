using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ThongTinHocVien
{

    public struct SinhVien
    {
        public string HoTen;
        public string GioiTinh;
        public DateTime NgaySinh;
        public string TruongHoc;
        public string NoiO;
        public string QueQuan;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            SinhVien[] DanhSachSinhVien =
            {
            new SinhVien { HoTen = "Lê Hồng Nhung", GioiTinh = "Nữ", NgaySinh = new DateTime(2004, 8, 25), TruongHoc = "NEU", NoiO = "Chung cư hoàng huy", QueQuan = "Thanh Hóa" },
            new SinhVien { HoTen = "Trần Minh Đức", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 2, 13), TruongHoc = "Trường Kinh doanh Công nghệ", NoiO = "Hà Nội", QueQuan = "Hải Dương" },
            new SinhVien { HoTen = "Vũ Đức Nam", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 5, 10), TruongHoc = "Cao đẳng fpt ponitechnich", NoiO = "Hà Nội", QueQuan = "Hải Dương" },
            new SinhVien { HoTen = "Lê Đinh Hùng Anh", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 4, 27), TruongHoc = "Lam Sơn", NoiO = "ktx Bách Khoa", QueQuan = "Thanh hóa" },
            new SinhVien { HoTen = "Nguyễn Trần Minh", GioiTinh = "Nam", NgaySinh = new DateTime(2003, 3, 25), TruongHoc = "HUST", NoiO = "250 minh khai", QueQuan = "Thái Bình" },
            new SinhVien { HoTen = "Lê Xuân Phúc", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 2, 17), TruongHoc = "HUST", NoiO = "Hà Nội", QueQuan = "Thanh Hóa" },
            new SinhVien { HoTen = "Hòang Trung Khải", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 10, 9), TruongHoc = "HUST", NoiO = "hoàng mai", QueQuan = " thanh hóa" },
            new SinhVien { HoTen = "Bùi Quốc Bảo", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 8, 14), TruongHoc = "HUST", NoiO = "đống đa", QueQuan = "thanh hóa" },
            new SinhVien { HoTen = "Nguyễn ngọc châu", GioiTinh = "Nam", NgaySinh = new DateTime(2001, 1, 17), TruongHoc = "đại học cần thơ", NoiO = "cần thơ", QueQuan = "sóc trăng" },
            new SinhVien { HoTen = "Nguyễn công nghĩa", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 5, 3), TruongHoc = "hb âcdemy", NoiO = "hà nội", QueQuan = "hà nội" },
            new SinhVien { HoTen = "Nguyễn chiều dương", GioiTinh = "Nam", NgaySinh = new DateTime(2004, 11, 9), TruongHoc = "greenwich", NoiO = "Vinhome", QueQuan = "Hà nội" },
            new SinhVien { HoTen = "Đặng thành long", GioiTinh = "Nam", NgaySinh = new DateTime(1999, 7, 16), TruongHoc = "hb academy", NoiO = "hà nội", QueQuan = "Hà nam" },

            };

            WriteLine("Thông tin học viên :");
            WriteLine("**********---************)");
            for (int i = 0; i < DanhSachSinhVien.Length; i++)
            {
                
                Console.WriteLine("Học viên thứ " + (i + 1) + ":");
                Console.WriteLine("Họ tên: " + DanhSachSinhVien[i].HoTen);
                Console.WriteLine("Giới tính: " + DanhSachSinhVien[i].GioiTinh);
                Console.WriteLine("Ngày sinh: " + DanhSachSinhVien[i].NgaySinh.ToString("dd/MM/yyyy"));
                Console.WriteLine("Trường học: " + DanhSachSinhVien[i].TruongHoc);
                Console.WriteLine("Địa chỉ: " + DanhSachSinhVien[i].NoiO);
                Console.WriteLine("Quê quán: " + DanhSachSinhVien[i].QueQuan);
                Console.WriteLine();
                
            }
            for (int i = 0; i < DanhSachSinhVien.Length; i++)
            {               
                string HoTen = DanhSachSinhVien[i].HoTen;
                WriteLine("Số khoảng trắng trong tên học viên " + (i + 1) + " là " + BienDem(HoTen));
            
            }
                                 
         
        }
        public static int BienDem(string stringtong)
        {
            int biendem = 0;
            string stringmain;
            for (int i = 0; i < stringtong.Length; i++)
            {
                stringmain = stringtong.Substring(i, 1);
                if (stringmain == " ")
                {
                    biendem++;
                }                   
            }
            return biendem;
        }

        }
}
