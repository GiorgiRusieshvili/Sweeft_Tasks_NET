namespace assignment_7
{
    public class Program
    {

        static void Main(string[] args)
        {

            using (var context = new DBContext())
            {
                var teacher1 = new Teacher { FirstName = "Anna", LastName = "Kakabaze" };
                var teacher2 = new Teacher { FirstName = "Manana", LastName = "Wereteli" };


                var pupil1 = new Pupil { FirstName = "Giorgi", LastName = "Rusieshvli", Teacher = new List<Teacher> { teacher1, teacher2 } };
                var pupil2 = new Pupil { FirstName = "Tsotne", LastName = "Dadiani", Teacher = new List<Teacher> { teacher1, teacher2 } };

                context.Pupils.Add(pupil1);
                context.Pupils.Add(pupil2);

                context.Teachers.Add(teacher1);
                context.Teachers.Add(teacher2);


                context.SaveChanges();
            }

            using (var context = new DBContext())
            {
                var teachers = context.Teachers
                        .Where(t => t.Pupils.Any(s => s.FirstName == "Giorgi"))
                        .ToList();

                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"{teacher.FirstName} teaches pupil named Giorgi.");
                }
            }

            Console.ReadKey();
        }
    }
}

