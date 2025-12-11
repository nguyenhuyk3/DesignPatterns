using System;

namespace DesignPattern.ClassDiagramArrow.Composition
{
    public class CClient
    {
        public void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ========== DEMO 1: NHÀ - PHÒNG ==========
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║   DEMO 1: NHÀ - PHÒNG                     ║");
            Console.WriteLine("║   (Phòng không tồn tại nếu nhà bị phá)    ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            {
                Nha nha = new Nha("123 Nguyễn Huệ, Q1, TP.HCM", 2);
                nha.ThongTin();

                Console.WriteLine("\n→ Khi biến 'nha' ra khỏi scope, destructor được gọi...");
            } // Destructor của Nha được gọi tại đây → Phòng cũng bị hủy

            Console.WriteLine("\nNhấn Enter để tiếp tục...");
            Console.ReadLine();
        }
    }
}
