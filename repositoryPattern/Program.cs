using IntroductionToEFCore.MyCoolDbContext;
using IntroductionToEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace IntroductionToEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Artists.Add(new Artist("petros","Greece"));
            myDbContext.SaveChanges();


            Console.WriteLine("- - - - - - -  - - -  - - - - - - - - -  -");
            Artist x = myDbContext.Artists.Where(a => a.Name == "petros").First();
             Console.WriteLine(x.Name);
             Console.WriteLine(x.Country);

             myDbContext.Songs.Add(new  Song("Test",x,1999));
             myDbContext.SaveChanges();

             myDbContext.Songs.ToList().ForEach(x => Console.WriteLine(x.Year));





        }
    }
}