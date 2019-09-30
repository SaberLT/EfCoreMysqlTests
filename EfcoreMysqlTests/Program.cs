using System;

namespace EfcoreMysqlTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ApplicationContext db= new ApplicationContext())
            {
                db.Database.EnsureCreated();

                User user1 = new User { Age = 12, Name = "12" };
                User user2 = new User { Age = 21, Name = "21" };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

                Console.ReadKey();
            }
        }
    }
}
