using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        private string? firstName; //string? declaring a nullable string
        private string? secondName;
        private int? Age;
        //default constructor - no arguments
        public Person()
        {

        }

        //parameterized constructor - 2 params
        public Person(string fn, string ln)
        {
            firstName = fn;
            secondName = ln;
        }

        //parameterized constructor - 3 params
        public Person(string fn, string ln, int _age)
        {
            firstName = fn;
            secondName = ln;
            Age = _age;
        }

        public string GetFirstName()
        { 
            return firstName;
        }

        public string GetSecondName()
        {
            return secondName;
        }
        public int? GetAge()
        {
            return Age;
        }
        public void SetAge(int _age) {

            Age =_age; }


        public void SetFirstName(string _firstname)
        {
            firstName = _firstname;
        }

        public void SetSecondName(string _secondname)
        {
            secondName = _secondname;
        }

        public override string ToString()
        {
            return $"The Person's Name is {firstName} and second Name is {secondName}.";
        }




    }
}
