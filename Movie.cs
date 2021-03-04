using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public Movie()
        {
            int MovieId=0;
            string MovieName= null;
            double Price =0;
        }
        public Movie(int MovieId,string MovieName,double Price)
        {
            this.MovieId = MovieId;
            this.MovieName = MovieName;
            this.Price = Price;
        }
      



    }
}
