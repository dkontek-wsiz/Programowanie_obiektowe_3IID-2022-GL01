using Lab4.Shapes;
using Lab4.Zad2;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
        }

        private static void Zad2()
        {
            var pesels = new List<long>()
            {
                13292313574,
                11272558326,
                11252623556,
                14222195514,
                13260515371,
                14281248851,
                13211445544,
                13290928392,
                14240472824,
                12310555824
            };

            var teacher = new Teacher();

            teacher.SetFirstName("Nauczyciel");
            teacher.SetLastName("Nauczyciel");
            teacher.Title = "Dr";

            var students = new List<Student>();

            var i = 0;
            foreach (var pesel in pesels)
            {
                var student = new Student();
                student.SetPesel(pesel.ToString());
                student.SetFirstName("Student");
                student.SetLastName(i.ToString());
                if (i == 4)
                    student.SetCanGoHomeAlone(true);
                students.Add(student);
                i++;
            }

            teacher.Students.AddRange(students);

            teacher.WhichStudentCanGoHomeAlone();

            teacher.DisplayClass(DateTime.Today);
        }

        static void Zad1()
        {
            var shapes = new List<Shape>();
            var shape1 = new Rectangle()
            {
                X = 5,
                Width = 2
            };

            shape1.Height = 3;

            shapes.Add(shape1);
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 7
            });
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 6
            });
            shapes.Add(new Rectangle()
            {
                X = 4,
                Width = 2
            });

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            for(int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }

          
        }
    }
}
