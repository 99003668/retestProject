using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking
{
    class Program
    {
         static List<Movie> MovieList = new List<Movie>(20);
        public static void Display()
        {
            foreach (Movie item in MovieList)
            {
                Console.WriteLine("Movie id : " + item.MovieId + "\t\tMovie Name : " + item.MovieName + "\t\tOne ticket Price : " + item.Price);
                
            }
        }

        static void Main(string[] args)
        {

            Movie[] MovieObj = new Movie[2];
            for (int i = 0; i < 2; i++)
            {
                MovieObj[0] = new Movie(1, "Harry Potter", 100);
                MovieObj[1] = new Movie(2, "Mirzapur", 100);

                MovieList.Add(MovieObj[i]);

            }
            Console.WriteLine("Login to proceed");

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            User UObj = new User();
            int result = UObj.Login(name, password);
            if (result == 1)
            {
                Console.WriteLine("Available Movies");
                Display();


            }


        }

    }
}
