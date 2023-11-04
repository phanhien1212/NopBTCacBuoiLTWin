using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi07_3
{
    class LoaiSach
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
       
        public LoaiSach() { }
        public LoaiSach(int maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
            

        }
    }
}
