using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Buoi2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> listSinhVien = NhapDSSinhVien();

            Console.WriteLine("Xuất danh sách sinh viên:");
            XuatDSSinhVien(listSinhVien);
            Console.WriteLine("Danh sách sinh viên khoa CNNT: ");
            DSSVCNTT(listSinhVien);
            Console.WriteLine("Danh sách sinh viên điểm trung bình lớn hơn 5:");
            DSSVLONHON5(listSinhVien);
            Console.WriteLine("Sắp xếp danh sách:");
            DSSVSAPXEP(listSinhVien);
            Console.WriteLine("Danh sách sinh viên lớn hơn 5 khoa CNTT:");
            DSSVLONHON5KHOACNTT(listSinhVien);
            Console.WriteLine("Danh sách sinh viên DTB cao nhất khoa CNTT:");
            DSSVDTBCAONHATKHOACNTT(listSinhVien);
            Console.ReadKey();
        }
        //Xây dựng hàm nhập tất cả sinh viên
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhập tổng số sinh viên n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ===Nhập danh sách sinh viên====");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);

            }
            return listSinhVien;
        }
        //Xây dựng hàm xuất tất cả sinh viên
        private static void XuatDSSinhVien(List<SinhVien> listSinhVien)
        {
            foreach(SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }
        //1.1 Xuất ra thông tin của các sinh viên thuộc khoa "CNTT" (nếu có).
        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                XuatDSSinhVien(listCNTT1);
            }
        }
        //1.2 Sử dụng Where lấy danh sách sinh viên có điểm > =5
        private static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên có điểm >= 5");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }
        private static void DSSVSAPXEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            XuatDSSinhVien(listSV);
        }
        private static void DSSVLONHON5KHOACNTT (List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5 && p.Khoa == "CNTT").ToList();
            if (listSV.Count == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT có điểm TB lớn hơn hoặc bằng 5.");
            }
            else
            {
                
                foreach (var sv in listSV)
                {
                    Console.WriteLine($"Tên: {sv.HoTen}, Điểm TB: {sv.DiemTB}, Khoa: {sv.Khoa}");
                }
            }
        }
        private static void DSSVDTBCAONHATKHOACNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT.");
            }
            else
            {
                
                double diemTBCaoNhat = listCNTT.Max(sv => sv.DiemTB);
                var danhSachSVDiemCaoNhat = listCNTT.Where(sv => sv.DiemTB == diemTBCaoNhat).ToList();
                foreach (var sv in danhSachSVDiemCaoNhat)
                {
                    Console.WriteLine($"Tên: {sv.HoTen}, Điểm TB: {sv.DiemTB}");
                }
            }
        }
    }
}
