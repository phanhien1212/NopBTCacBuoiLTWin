using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<Student> listStudent = NhapDStudent();
            List<Teacher> listTeacher = NhapGV();
            Console.WriteLine("Xuất danh sách sinh viên");
            XuatDSStudent(listStudent);
            Console.WriteLine("Danh sách sinh viên khoa CNNT");
            DSSVCNTT(listStudent);
            Console.WriteLine("Danh sách sinh viên bé hơn 5 khoa CNTT");
            DSSVBEHON5KHOACNTT(listStudent);
            Console.WriteLine("Danh sách giáo viên có địa chỉ quận 9 ");
            DSGVDIACHI(listTeacher);
            Console.WriteLine("Danh sách giáo viên có mã giảng viên");
            GVCOMAGV(listTeacher);
            Console.WriteLine("Danh sách sinh vien dtb cao nhất khoa CNTT");
            DSSVDTBCAONHATKHOACNTT(listStudent);
            Console.ReadKey();
        }
        //Xây dựng hàm nhập tất cả tudent
        private static List<Student> NhapDStudent()
        {
            List<Student> listStudent = new List<Student>();
            Console.Write("Nhập tổng số student n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ===Nhập danh sách student====");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap student Thu {0}:", i + 1);
                Student sv = new Student();
                sv.NhapSV();
                listStudent.Add(sv);

            }
            return listStudent;
        }
        //Xây dựng hàm xuất tất cả sinh viên
        private static void XuatDSStudent(List<Student> listStudent)
        {
            foreach (Student sv in listStudent)
            {
                sv.XuatSV();
            }
        }
        private static List<Teacher> NhapGV()
        {
            List<Teacher> listTeacher = new List<Teacher>();
            Console.Write("Nhập tổng số GV n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ===Nhập danh sách GV====");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap GV Thu {0}:", i + 1);
                Teacher gv = new Teacher();
                gv.NhapGV();
                listTeacher.Add(gv);

            }
            return listTeacher;
        }
        //Xây dựng hàm xuất tất cả sinh viên
        private static void XuatDSTeacher(List<Teacher> listTeacher)
        {
            foreach (Teacher gv in listTeacher)
            {
                gv.XuatGV();
            }
        }
        //1.1 Xuất ra thông tin của các sinh viên thuộc khoa "CNTT" (nếu có).
        private static void DSSVCNTT(List<Student> listStudent)
        {
            List<Student> listCNTT1 = listStudent.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                XuatDSStudent(listCNTT1);
            }
        }
        private static void DSSVBEHON5KHOACNTT(List<Student> listStudent)
        {
            List<Student> listSV = listStudent.Where(p => p.DiemTB < 5 && p.Khoa == "CNTT").ToList();
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
        private static void DSGVDIACHI(List<Teacher> listTeacher)
        {
            List<Teacher> listGVQ9 = listTeacher.Where(p => p.DiaChi.Contains("Quận 9")).ToList();
           

            // Xuất danh sách giáo viên có địa chỉ "Quận 9"
           
            foreach (var gv in listGVQ9)
            {
                Console.WriteLine($"Tên: {gv.HoTen}, Địa chỉ: {gv.DiaChi}");
            }

        }
        private static void GVCOMAGV(List<Teacher> listTeacher)
        {
            List<Teacher> GVMa = listTeacher.Where(p => p.MaGV == "CHN060286").ToList();
            if (GVMa.Count != 0)
            {
                var GiangVienCoMa = GVMa.Where(sv => sv.MaGV == "CHN060286").ToList();
                XuatDSTeacher(GiangVienCoMa);
            }
            else
            {
                Console.WriteLine("Khong co giang vien co ma trung khop");
            }
        }
        private static void DSSVDTBCAONHATKHOACNTT(List<Student> listStudent)
        {
            List<Student> listCNTT = listStudent.Where(p => p.Khoa == "CNTT").ToList();
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
