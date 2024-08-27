using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videos = new List<Video>();

        public VideoStore()
        {
            _videos = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _videos.Add(new Video(title));
            Console.WriteLine(title);
        }

        public Video CheckOut(string title)
        {
            foreach(var video in _videos)
            {
                if(video.Title == title)
                {
                    video.CheckOut();

                    return video;
                }
            }

            return null;
        }

        public void Return(string title)
        {
            foreach(var video in _videos)
            {
                if(video.Title == title)
                {
                    video.Return();
                    return;
                }
            }
        }

        public void ReceiveRating(string title, double rating)
        {
            foreach(var video in _videos)
            {
                if(video.Title == title)
                {
                    video.ReceivedRating(rating);
                    return;
                }
            }
        }

        public List<Video> ListInventory()
        {
            return _videos.ToList();
        }
    }
}
