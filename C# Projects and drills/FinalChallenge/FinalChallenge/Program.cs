using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter First name of new student: ");
                var firstname = Console.ReadLine();
                Console.Write("Enter Last name of new student: ");
                var lastname = Console.ReadLine();
                var student = new Student() { FirstName = firstname , LastName = lastname };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from x in db.Students
                            orderby x.LastName
                            select x;

                Console.WriteLine("New Students last name in database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.LastName);
                }

            
            
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Grade Grade { get; set; }

    }
    public class Grade
    {
        public int GradeID { get; set; }
        public int TopGrade { get; set; }
        public virtual List<Student>  Students { get; set; }
    }




    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }   
        public DbSet<Grade> Grades { get; set; }
    }


}
