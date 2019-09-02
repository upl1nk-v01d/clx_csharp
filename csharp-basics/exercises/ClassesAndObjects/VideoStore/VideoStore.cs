using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title != title) continue;
                if (!video.Available())
                {
                    Console.WriteLine("not available");
                }
                else
                {
                    video.BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title != title) continue;
                if (video.Available())
                {
                    Console.WriteLine("Cant return not rented video.");
                }
                else
                {
                    video.BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
