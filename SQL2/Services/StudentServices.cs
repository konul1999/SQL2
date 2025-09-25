using SQL2.Data;
using SQL2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2.Services
{
    internal class StudentServices
    {
        private static Sql _sql = new Sql();

        public void Add(Student student)
        {
            int result = _sql.ExecuteCommand($"INSERT INTO Students VALUES ('{student.Name}','{student.Surname}',{student.Age})");
            if (result > 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        public List<Student> GetAll()
        {
            DataTable table = _sql.ExecuteQuery("SELECT * FROM Students");
            List<Student> students = new List<Student>();
            foreach (DataRow dr in table.Rows)
            {
                Student student = new Student()
                {
                    Id = (int)dr["Id"],
                    Name = (string)dr["Name"],
                    Surname = dr["Surname"].ToString(),
                    Age = (int)dr["Age"]
                };
                students.Add(student);
            }
            return students;
        }
        public void Remove(int id)
        {
            int result = _sql.ExecuteCommand($"DELETE FROM Students WHERE Id={id}");
            if (result > 0)
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        public void Update(Student student)
        {
            int result = _sql.ExecuteCommand($"UPDATE Students SET Name='{student.Name}', Surname='{student.Surname}', Age={student.Age} WHERE Id={student.Id}");
            if (result > 0)
            {
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

    }
}
