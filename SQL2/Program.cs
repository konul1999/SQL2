using SQL2.Models;
using SQL2.Services;

namespace SQL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentServices services = new StudentServices();

            //Student student1 = new Student()
            //{
            //    Name= "Test",
            //    Surname ="Testov",
            //    Age = 23
            //};
            //services.Add(student1);

            //List<Student> students = services.GetAll();
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name + " "+ student.Surname);
            //}

            //services.Remove(1);

            //Student student2 = new Student()
            //{
            //    Id=1,
            //    Name = "Ali",
            //    Surname = "Aliyev",
            //    Age = 21
            //};
            //services.Update(student2);

            //Student student2 = services.GetById(1);
            //Console.WriteLine(student2.Id + " "+student2.Name +" "+ student2.Surname+" "+ student2.Age);
        }
    }
}
