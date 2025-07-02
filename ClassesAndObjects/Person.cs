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

        public string GetFirstName()
        { 
            return firstName;
        }

        public string GetSecondName()
        {
            return secondName;
        }

        public void SetFirstName(string _firstname)
        {
            firstName = _firstname;
        }

        public void SetSecondName(string _secondname)
        {
            secondName = _secondname;
        }





    }
}
