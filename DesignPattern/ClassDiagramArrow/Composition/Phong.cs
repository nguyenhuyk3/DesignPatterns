using System;

namespace DesignPattern.ClassDiagramArrow.Composition
{
    public class Phong
    {
        public string TenPhong { get; set; }
        public double DienTich { get; set; }
        public int SoCua { get; set; }

        public Phong(string tenPhong, double dienTich, int soCua)
        {
            TenPhong = tenPhong;
            DienTich = dienTich;
            SoCua = soCua;
            Console.WriteLine($"  ✓ Xây phòng: {tenPhong} ({dienTich}m²)");
        }

        public void ThongTin()
        {
            Console.WriteLine($"    • {TenPhong}: {DienTich}m², {SoCua} cửa");
        }

        ~Phong()
        {
            Console.WriteLine($"  ✗ Phá dỡ phòng: {TenPhong}");
        }
    }
}
