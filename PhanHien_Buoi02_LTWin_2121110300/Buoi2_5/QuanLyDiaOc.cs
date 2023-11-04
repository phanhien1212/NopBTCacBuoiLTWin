using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_5
{
    class QuanLyDiaOc
    {
        List<KhuDat> danhSachDiaOc = new List<KhuDat>();

        public void ThemKhuDat(KhuDat khuDat)
        {
            danhSachDiaOc.Add(khuDat);
        }

        public void XuatTongGiaBan()
        {
            decimal tongGiaBanKhuDat = danhSachDiaOc.OfType<KhuDat>().Sum(k => k.GiaBan);
            decimal tongGiaBanNhaPho = danhSachDiaOc.OfType<NhaPho>().Sum(np => np.GiaBan);
            decimal tongGiaBanChungCu = danhSachDiaOc.OfType<ChungCu>().Sum(cc => cc.GiaBan);

            Console.WriteLine($"Tổng giá bán Khu Đất: {tongGiaBanKhuDat} VND");
            Console.WriteLine($"Tổng giá bán Nhà Phố: {tongGiaBanNhaPho} VND");
            Console.WriteLine($"Tổng giá bán Chung Cư: {tongGiaBanChungCu} VND");
        }

        public void XuatDanhSachDatLonVaNhaPhoMoi()
        {
            var danhSachDatLon = danhSachDiaOc.OfType<KhuDat>().Where(k => k.DienTich > 100);
            var danhSachNhaPhoMoi = danhSachDiaOc.OfType<NhaPho>().Where(np => np.DienTich > 60 && np.NamXayDung >= 2019);

            foreach (var khuDat in danhSachDatLon)
            {
                Console.WriteLine($"Khu đất  > 100m2: Địa điểm: {khuDat.DiaDiem}, Diện tích: {khuDat.DienTich} m2");
            }

            foreach (var nhaPho in danhSachNhaPhoMoi)
            {
                Console.WriteLine($"Nhà phố mới (>60m2, xây từ 2019): Địa điểm: {nhaPho.DiaDiem}, Diện tích: {nhaPho.DienTich} m2, Năm xây dựng: {nhaPho.NamXayDung}");
            }
        }

        public void TimKiemThongTin(string diaDiem, decimal gia, double dienTich)
        {
            var ketQuaTimKiem = danhSachDiaOc.Where(
                x => x.DiaDiem.ToLower().Contains(diaDiem.ToLower()) &&
                     x.GiaBan <= gia &&
                     x.DienTich >= dienTich
            );

            foreach (var ketQua in ketQuaTimKiem)
            {
                if (ketQua is NhaPho)
                {
                    Console.WriteLine($"Nhà Phố phù hợp: Địa điểm: {ketQua.DiaDiem}, Giá: {ketQua.GiaBan} VND, Diện tích: {ketQua.DienTich} m2");
                }
                else if (ketQua is ChungCu)
                {
                    Console.WriteLine($"Chung Cư phù hợp: Địa điểm: {ketQua.DiaDiem}, Giá: {ketQua.GiaBan} VND, Diện tích: {ketQua.DienTich} m2");
                }
            }
        }
    }

}
