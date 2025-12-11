using System;

namespace DesignPattern.ClassDiagramArrow.Dependency
{
    // Class EmailSender - phụ thuộc vào Email
    public class EmailSender
    {
        // Dependency: Email được truyền vào như tham số, chỉ dùng tạm thời
        public void GuiEmail(Email email)
        {
            Console.WriteLine("=== GỬI EMAIL ===");
            Console.WriteLine($"Đến: {email.To}");
            Console.WriteLine($"Tiêu đề: {email.Subject}");
            Console.WriteLine($"Nội dung: {email.Body}");
            Console.WriteLine("Email đã được gửi thành công!\n");
            // Sau khi method kết thúc, không còn giữ reference đến email
        }

        // Dependency: Tạo đối tượng Email bên trong method
        public Email TaoEmailChaoMung(string nguoiNhan)
        {
            // Email chỉ tồn tại trong phạm vi method này
            Email email = new Email(
                nguoiNhan,
                "Chào mừng bạn!",
                "Cảm ơn bạn đã đăng ký dịch vụ của chúng tôi."
            );
            return email;
        }
    }
}
