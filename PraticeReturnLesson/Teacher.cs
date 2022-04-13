using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeReturnLesson
{
     class Teacher : Person
    {
        private static int _id;
        private int _experience;
        public int Id { get; }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if(value>=1 && value <= 80)
                {
                    _experience = value;
                }
            }
        }

        public Teacher(string name, string surname, int age,int exp) : base(name,surname,age)
        {
            _id++;
            Id = _id;
            Experience = exp;
            
            
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname},Age: {Age},Experience: {Experience} ");
        }
    }
}
