using System;

namespace DesignPattern.Creational.PrototypeDP
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        /*
         * MemberwiseClone là một phương thức được định nghĩa trong lớp gốc System.Object của C#.
         * Nó thực hiện shallow copy (sao chép nông) của đối tượng.
         * Phương thức này có protected access modifier.
         * Cơ chế hoạt động:
         *      - Khi gọi MemberwiseClone, runtime tạo một đối tượng mới:
         *          + Các giá trị kiểu primitive (int, bool, double, ...) được copy sang đối tượng mới.
         *          + Các tham chiếu (reference type) không được clone, mà tham chiếu giống nhau.
         *            => Hai đối tượng cùng trỏ đến chung dữ liệu bên trong.
         */
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();

            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);

            return clone;
        }
    }
}
