using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvailable;
        private List<double> _ratingList;

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _ratingList = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _isAvailable = false;
        }

        public void BeingReturned()
        {
            _isAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratingList.Add(rating);
        }

        public double AverageRating()
        {
            double sum = 0;
            foreach (var rating in _ratingList)
            {
                sum += rating;
            }
            return sum / _ratingList.Count;
        }

        public bool Available()
        {
            return _isAvailable;
        }

        public string Title
        {
            get { return _title; }
        }

        public override string ToString()
        {
            return $"{_title} {AverageRating()} {_isAvailable}";
        }
    }
}
