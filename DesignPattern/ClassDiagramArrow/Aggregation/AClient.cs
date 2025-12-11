using System;

namespace DesignPattern.ClassDiagramArrow.Aggregation
{
    public class AClient
    {
        public void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ========== DEMO 1: TRƯỜNG HỌC ==========
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║   DEMO 1: TRƯỜNG HỌC - GIÁO VIÊN          ║");
            Console.WriteLine("║   (Giáo viên có thể chuyển trường)        ║");
            Console.WriteLine("╚════════════════════════════════════════════╝\n");

            // Tạo giáo viên độc lập
            var gv1 = new GiaoVien("GV001", "Nguyễn Văn An", "Toán", 10);
            var gv2 = new GiaoVien("GV002", "Trần Thị Bình", "Văn", 8);
            var gv3 = new GiaoVien("GV003", "Lê Minh Châu", "Anh", 5);

            // Tạo trường và thêm giáo viên
            var truongA = new TruongHoc("THPT Lê Quý Đôn", "123 Lê Lợi, Q1");
            truongA.ThemGiaoVien(gv1);
            truongA.ThemGiaoVien(gv2);
            truongA.HienThiThongTin();

            var truongB = new TruongHoc("THPT Trần Hưng Đạo", "456 Nguyễn Huệ, Q3");
            truongB.ThemGiaoVien(gv3);

            // Giáo viên chuyển trường (vẫn tồn tại)
            Console.WriteLine("\n--- Chuyển trường ---");
            truongA.XoaGiaoVien(gv1);
            truongB.ThemGiaoVien(gv1);

            truongA.HienThiThongTin();
            truongB.HienThiThongTin();
        }
    }
}
