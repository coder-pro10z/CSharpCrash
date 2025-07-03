using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person  //CSharp has only single Inheritence, but you can inherit multiple interfaces
    {
        public int gpa { get; set; }
        public int Id { get; set; }


    }
}
