namespace bai10
{
    internal class SanPhamBase
    {
        public double dongia { get; set; }
        public int masanpham { get; set; }
        public int soluong { get; set; }
        public string tensanpham { get; set; }


        public double ThanhTien()
        {
            return dongia * soluong;
        }
    }
}