using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class SanPham
    {
        public int masanpham { get; set; }
        public string tensanpham { get; set; }
        public double dongia { get; set; }
        public int soluong { get; set; }
        public SanPham()
        {

        }

        public SanPham(int masanpham, string tensanpham, double dongia, int soluong)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.soluong = soluong;
        }

        public double ThanhTien()
        {
            return dongia * soluong;
        }
        public void In()
    

    }
}
