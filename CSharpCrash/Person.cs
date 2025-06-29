using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCrash
{
    public class Person
    {
        //constructor
        private string name;
        private int age;
        public Person(string name,int age) {
            this.name = name;
            this.age = age;
            }

        public string Name {
            get { return name; } 
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Greet()
        {
            Console.WriteLine("Hi! My name is {0}, and my age is {1}",name,age);
        }
    }   
}
    