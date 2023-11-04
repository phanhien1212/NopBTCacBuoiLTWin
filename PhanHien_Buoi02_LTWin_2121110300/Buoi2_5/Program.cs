using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_5
{
    class Program
    {
        static void Main()
        {
            QuanLyDiaOc quanLyDiaOc = new QuanLyDiaOc();

            Console.WriteLine("Nhập thông tin cho Khu Đất:");
            Console.Write("Địa điểm: ");
            string diaDiemKhuDat = Console.ReadLine();
            Console.Write("Giá bán (VND): ");
            decimal giaBanKhuDat = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Diện tích (m2): ");
            double dienTichKhuDat = Convert.ToDouble(Console.ReadLine());

            KhuDat khuDat = new KhuDat { DiaDiem = diaDiemKhuDat, GiaBan = giaBanKhuDat, DienTich = dienTichKhuDat };
            quanLyDiaOc.ThemKhuDat(khuDat);
    
            Console.WriteLine("\nNhập thông tin cho Nhà Phố:");
            Console.Write("Địa điểm: ");
            string diaDiemNhaPho = Console.ReadLine();
            Console.Write("Giá bán (VND): ");
            decimal giaBanNhaPho = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Diện tích (m2): ");
            double dienTichNhaPho = Convert.ToDouble(Console.ReadLine());
            Console.Write("Năm xây dựng: ");
            int namXayDung = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số tầng: ");
            int soTang = Convert.ToInt32(Console.ReadLine());

            NhaPho nhaPho = new NhaPho { DiaDiem = diaDiemNhaPho, GiaBan = giaBanNhaPho, DienTich = dienTichNhaPho, NamXayDung = namXayDung, SoTang = soTang };
            quanLyDiaOc.ThemKhuDat(nhaPho);

           
            Console.WriteLine("\nNhập thông tin cho Chung Cư:");
            Console.Write("Địa điểm: ");
            string diaDiemChungCu = Console.ReadLine();
            Console.Write("Giá bán (VND): ");
            decimal giaBanChungCu = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Diện tích (m2): ");
            double dienTichChungCu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tầng: ");
            int tang = Convert.ToInt32(Console.ReadLine());

            ChungCu chungCu = new ChungCu { DiaDiem = diaDiemChungCu, GiaBan = giaBanChungCu, DienTich = dienTichChungCu, Tang = tang };
            quanLyDiaOc.ThemKhuDat(chungCu);

            Console.WriteLine("\nThông tin Khu Đất, Nhà Phố và Chung Cư:");
            quanLyDiaOc.XuatTongGiaBan();
            quanLyDiaOc.XuatDanhSachDatLonVaNhaPhoMoi();

            Console.WriteLine("\nNhập thông tin cần tìm kiếm:");
            Console.Write("Địa điểm cần tìm: ");
            string diaDiemCanTim = Console.ReadLine();
            Console.Write("Giá cần tìm (VND): ");
            decimal giaCanTim = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Diện tích cần tìm (m2): ");
            double dienTichCanTim = Convert.ToDouble(Console.ReadLine());

            quanLyDiaOc.TimKiemThongTin(diaDiemCanTim, giaCanTim, dienTichCanTim);

            Console.ReadLine();
        }
    }
}
