using System;

namespace DesignPattern.ClassDiagramArrow.Association
{
    public class AClient
    {
        public void Main()
        {
            // Tạo đối tượng Bệnh nhân (độc lập)
            Patient patientHung = new Patient("Hùng", "Cảm cúm");

            // Tạo đối tượng Bác sĩ (độc lập)
            Doctor doctorMai = new Doctor("Mai");

            // Thiết lập mối quan hệ Association: Bác sĩ khám cho Bệnh nhân
            doctorMai.TreatPatient(patientHung);

            // --- KIỂM CHỨNG VÒNG ĐỜI ĐỘC LẬP ---
            // Nếu biến doctorMai bị null (Bác sĩ nghỉ việc)
            doctorMai = null;

            // Bệnh nhân Hùng VẪN TỒN TẠI và có thể đi khám bác sĩ khác
            Console.WriteLine($"Tình trạng bệnh nhân {patientHung.Name}: Vẫn còn sống và đang đợi bác sĩ khác.");
        }
    }
}
