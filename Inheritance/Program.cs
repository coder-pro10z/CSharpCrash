using Inheritance;
using System.Globalization;

Student student1 = new Student();
student1.gpa = 3;
student1.Name = "Praveen";
student1.Id = 1;
//student1.gpa = 3;

Console.WriteLine($"{student1.Name}'s ID is {student1.Id} and Gpa is :{student1.gpa}");

student1.StartCourse();

student1.StopCourse();
