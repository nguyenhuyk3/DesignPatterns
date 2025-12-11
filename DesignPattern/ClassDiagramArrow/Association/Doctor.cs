using System;

namespace DesignPattern.ClassDiagramArrow.Association
{
    public class Doctor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }

        // Đây là nơi thể hiện Association:
        // Bác sĩ "sử dụng" đối tượng Bệnh nhân trong phương thức của mình
        public void TreatPatient(Patient patient)
        {
            Console.WriteLine($"Bác sĩ {this.Name} đang khám cho bệnh nhân {patient.Name} bị bệnh {patient.Disease}.");
        }
    }
}
