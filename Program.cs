using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinh
{
    class Program
    {
        
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"ID: {Id}, Name: {Name}, Age: {Age}";
            }
        }

        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Anh", Age = 16 },
                new Student { Id = 2, Name = "Lan", Age = 18 },
                new Student { Id = 3, Name = "Hong", Age = 20 },
                new Student { Id = 4, Name = "Bao", Age = 15 },
                new Student { Id = 5, Name = "An", Age = 19 }
            };

            
            Console.WriteLine("Danh sach toan bo cac hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            
            Console.WriteLine("\nHoc sinh co tuoi tu 15 -18 tuoi:");
            var studentsInAgeRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine(student);
            }

           
            Console.WriteLine("\nHoc sinh co chu bat dau bang chu 'A':");
            var studentsWithNameA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in studentsWithNameA)
            {
                Console.WriteLine(student);
            }

            
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh la: {totalAge}");


            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            Console.WriteLine("\nHoc sinh co tuoi lon nhat la:");
            foreach (var student in oldestStudents)
            {
                Console.WriteLine(student);
            }

            
            Console.WriteLine("\nDanh sach sap xep hoc sinh theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
