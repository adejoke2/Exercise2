using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ruqayah", 2, "07087574221", "Lagos");
            Console.WriteLine($"{student1.Name}, Roll No: {student1.RollNo}, Phone No: {student1.PhoneNo}, Address:{student1.Address}");

            Student student2 = new Student("Maryam", 3, "09087180135", "Osun");
            Console.WriteLine($"{student2.Name}, Roll No: {student2.RollNo}, Phone No: {student2.PhoneNo}, Address:{student2.Address}");

        }
    }
}
