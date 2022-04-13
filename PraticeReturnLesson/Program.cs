using System;

namespace PraticeReturnLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int experience;



            do
            {
                Console.WriteLine("Please enter Age");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age<0);

            do
            {
                Console.WriteLine("Please enter Experience");
                experience = Convert.ToInt32(Console.ReadLine());

            } while (experience<1 || experience>80);


            Student student = new Student("Baxseli", "Nezerov", age);
            Student student1 = new Student("Tural", "Hamidzade", age);
            Console.WriteLine("\nStudents");
            student.ShowInfo1();
            student1.ShowInfo1();

            Console.WriteLine("\nTeachers");
            Teacher teacher = new Teacher("Cavid", "Asadullayev", age, experience);
            Teacher teacher1 = new Teacher("Sunal", "Jabili", age, experience);
            teacher.ShowInfo();
            teacher1.ShowInfo();

            Group group = new Group();
            Console.WriteLine("\nAdd new student");
            group.AddStudent(student);
            group.AddStudent(student1);

            foreach (var item in group.students)
            {
                item.ShowInfo1();
            }

           
        }
    }
}
