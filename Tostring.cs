using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public Person(string name = "Ruslan", string surname= "Aliyev", int age= 20, int weight= 85, int height = 179)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Weight { get; private set; }
        public int Height { get; private set; }

        public override string ToString()
        {
            return Name + "  " + Surname+ "  "+Age+ "  "+Weight+ "  "+Height;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            Console.WriteLine(person.ToString());
        }
    }
}
