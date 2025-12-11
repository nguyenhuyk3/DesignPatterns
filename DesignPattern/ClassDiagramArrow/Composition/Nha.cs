using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.ClassDiagramArrow.Composition
{
    public class Nha
    {
        public string DiaChi { get; set; }
        public int SoTang { get; set; }
        private List<Phong> danhSachPhong; // Composition - phòng thuộc về nhà

        public Nha(string diaChi, int soTang)
        {
            DiaChi = diaChi;
            SoTang = soTang;
            danhSachPhong = new List<Phong>();

            Console.WriteLine($"\n=== BẮT ĐẦU XÂY NHÀ: {diaChi} ===");

            // Tạo phòng BÊN TRONG constructor - Composition
            XayPhong();
        }

        private void XayPhong()
        {
            // Phòng được tạo ra cùng với nhà
            danhSachPhong.Add(new Phong("Phòng khách", 30, 2));
            danhSachPhong.Add(new Phong("Phòng bếp", 15, 1));
            danhSachPhong.Add(new Phong("Phòng ngủ chính", 25, 2));
            danhSachPhong.Add(new Phong("Phòng ngủ 2", 20, 2));
            danhSachPhong.Add(new Phong("Nhà vệ sinh", 8, 1));
        }

        public void ThongTin()
        {
            Console.WriteLine($"\n╔══════════════════════════════════╗");
            Console.WriteLine($"║  NHÀ: {DiaChi}");
            Console.WriteLine($"╚══════════════════════════════════╝");
            Console.WriteLine($"Số tầng: {SoTang}");
            Console.WriteLine($"Tổng số phòng: {danhSachPhong.Count}");
            Console.WriteLine($"Tổng diện tích: {danhSachPhong.Sum(p => p.DienTich)}m²");
            Console.WriteLine("\nCác phòng:");
            foreach (var phong in danhSachPhong)
            {
                phong.ThongTin();
            }
        }

        ~Nha()
        {
            Console.WriteLine($"\n=== PHÁ DỠ NHÀ: {DiaChi} ===");
            Console.WriteLine("→ Tất cả các phòng cũng bị phá dỡ theo!");
        }
    }
}
