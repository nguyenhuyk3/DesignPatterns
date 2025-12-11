using System;

namespace DesignPattern.ClassDiagramArrow.Dependency
{
    public class DClient
    {
        public void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║   DEMO 1: EMAIL SERVICE            ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            EmailSender emailSender = new EmailSender();
            Email email1 = new Email(
                "khachhang@example.com",
                "Xác nhận đơn hàng",
                "Đơn hàng #12345 của bạn đã được xác nhận."
            );
            emailSender.GuiEmail(email1); // email1 chỉ được dùng tạm thời

            Email email2 = emailSender.TaoEmailChaoMung("user@example.com");
            emailSender.GuiEmail(email2);
        }
    }
}
