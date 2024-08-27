using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private bool CheckedOut { get; set; }

        private List<double> Ratings { get; set; }

        public Video(string title)
        {
            Title = title;
            CheckedOut = false;
            Ratings = new List<double>();
        }

        public string Title { get; set; }

        public double AverageRating => Ratings.Average();

        public void CheckOut()
        {
            CheckedOut = true; 
        }

        public void Return()
        {
            CheckedOut = false;
        }

        public void ReceivedRating(double rating)
        {
            Ratings.Add(rating);
        }
    }
}
