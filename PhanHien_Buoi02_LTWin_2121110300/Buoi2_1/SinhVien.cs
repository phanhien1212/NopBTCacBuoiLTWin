﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_1
{
    class SinhVien
    {
        //Khai báo thuộc tính
        private string MaSV;
        private string HoTen;
        private double DiemTB;
        private string Khoa;

        public SinhVien() { }
        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiemTB = diemtb;
            this.Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t HoTen:{1} \t DiemTB:{2} \t Khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }
   
}
