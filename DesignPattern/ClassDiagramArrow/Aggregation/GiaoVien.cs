using System;

// Giáo viên có thể tồn tại độc lập với trường học
namespace DesignPattern.ClassDiagramArrow.Aggregation
{
    public class GiaoVien
    {
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string MonDay { get; set; }
        public int NamKinhNghiem { get; set; }

        public GiaoVien(string maGV, string hoTen, string monDay, int namKinhNghiem)
        {
            MaGV = maGV;
            HoTen = hoTen;
            MonDay = monDay;
            NamKinhNghiem = namKinhNghiem;
        }

        public void ThongTin()
        {
            Console.WriteLine($"  - GV {HoTen} ({MaGV}): {MonDay}, {NamKinhNghiem} năm kinh nghiệm");
        }
    }
}
