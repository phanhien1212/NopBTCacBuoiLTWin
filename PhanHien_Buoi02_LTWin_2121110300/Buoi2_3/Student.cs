using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    internal class Student : Person
    {
        public string MaSV;
        public double DiemTB;
        public string Khoa;

        public Student() { }

        public Student(string maSV, double diemTB, string khoa)
        {
            MaSV = maSV;
            DiemTB = diemTB;
            Khoa = khoa;
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t DiemTB:{1} \t Khoa:{2} \t HoTen:{3} ", MaSV, DiemTB, Khoa, HoTen);
        }
    }
}
