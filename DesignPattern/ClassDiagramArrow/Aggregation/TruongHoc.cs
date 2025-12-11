using System;
using System.Collections.Generic;

namespace DesignPattern.ClassDiagramArrow.Aggregation
{
    // Trường học chứa nhiều giáo viên (Aggregation)
    public class TruongHoc
    {
        public string TenTruong { get; set; }
        public string DiaChi { get; set; }
        private List<GiaoVien> danhSachGiaoVien;

        public TruongHoc(string tenTruong, string diaChi)
        {
            TenTruong = tenTruong;
            DiaChi = diaChi;
            danhSachGiaoVien = new List<GiaoVien>();
        }

        // Thêm giáo viên đã tồn tại (không tạo mới)
        public void ThemGiaoVien(GiaoVien giaoVien)
        {
            if (!danhSachGiaoVien.Contains(giaoVien))
            {
                danhSachGiaoVien.Add(giaoVien);
                Console.WriteLine($"✓ Đã thêm GV {giaoVien.HoTen} vào {TenTruong}");
            }
        }

        // Giáo viên rời khỏi trường nhưng vẫn tồn tại
        public void XoaGiaoVien(GiaoVien giaoVien)
        {
            if (danhSachGiaoVien.Remove(giaoVien))
            {
                Console.WriteLine($"✓ GV {giaoVien.HoTen} đã rời {TenTruong}");
                Console.WriteLine($"  (Giáo viên vẫn tồn tại, có thể chuyển trường khác)");
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"\n=== {TenTruong.ToUpper()} ===");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Số giáo viên: {danhSachGiaoVien.Count}");
            Console.WriteLine("Danh sách giáo viên:");
            foreach (var gv in danhSachGiaoVien)
            {
                gv.ThongTin();
            }
        }
    }
}
