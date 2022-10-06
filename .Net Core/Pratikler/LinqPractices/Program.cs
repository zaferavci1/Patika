using System;
using System.Linq;
using LinqPractices;
using LinqPractices.DbOperations;

namespace Pratikler
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find()
            System.Console.WriteLine("**** Find ***");
            var student=_context.Students.Where(x => x.StudentId == 1).FirstOrDefault(); 
            student = _context.Students.Find(1);
            Console.WriteLine(student.Name);

            //FirstOrDefaoult
            System.Console.WriteLine("**** FirstOrDefaoult ***");
            student = _context.Students.Where(x => x.Surname == "Avci").FirstOrDefault();
            Console.WriteLine(student.Name);

            student = _context.Students.FirstOrDefault(x => x.Surname == "Avci");
            Console.WriteLine(student.Name);

            //SingleOrDefault
            System.Console.WriteLine("*** SingleOrDefault ***");
            student = _context.Students.SingleOrDefault(student => student.Name == "Serkan");
            // 2 tane veri gelirse sıkıntı olur
            System.Console.WriteLine(student.Surname);

            //ToList
            System.Console.WriteLine("*** ToList ***");
            var studentList = _context.Students.Where(x => x.ClassId == 2).ToList();

            foreach (var item in studentList)
            {
                System.Console.WriteLine(item.Name + " " + item.Surname);
            }

            //OrderBy
            System.Console.WriteLine("\n*** OrderBy ***");

            students = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach (var item in students)
            {
                System.Console.WriteLine(item.Name + " " + item.Surname);
            }

            //OrderByDesc
            System.Console.WriteLine("\n*** OrderByDesc ***");

            students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach (var item in students)
            {
                System.Console.WriteLine(item.Name + " " + item.Surname);
            }

            //Anonymous object Result
            System.Console.WriteLine("\n*** Anonymous object Result ****");

            var anonymousobject = _context.Students
                                .Where(x => x.ClassId == 2)
                                .Select(x => new {
                                    Id = x.StudentId,
                                    FullName=x.Name + " " + x.Surname
                                });
            foreach (var item in anonymousobject)
            {
                System.Console.WriteLine(item.Id + " "+ item.FullName);
            }
        }
    }
}
