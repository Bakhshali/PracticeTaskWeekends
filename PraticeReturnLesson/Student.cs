using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeReturnLesson
{
    internal class Student:Person
    {
        private static int _id;
        public int Id { get;}

        string [] Lesson = new string [0];

        public Student(string name, string surname, int age) : base (name, surname, age)
        {
            _id++;
            Id = _id;
        }
        public void ShowInfo1()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname},Age: {Age}");
        }
    }
}
