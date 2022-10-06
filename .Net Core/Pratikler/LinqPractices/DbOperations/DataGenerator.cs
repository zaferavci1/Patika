using System.Linq;

namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange
                (
                    new Student(){
                        Name="Serkan",
                        Surname="Yilmaz",
                        ClassId=1
                    },
                    new Student(){
                        Name="Zafer",
                        Surname="Avci",
                        ClassId=1
                    },
                    new Student(){
                        Name="Zikriye",
                        Surname="Urkmez",
                        ClassId=2
                    },
                    new Student(){
                        Name="Merve",
                        Surname="Yilmaz",
                        ClassId=2
                    }
                );

                context.SaveChanges();
            }
        }
    }
}