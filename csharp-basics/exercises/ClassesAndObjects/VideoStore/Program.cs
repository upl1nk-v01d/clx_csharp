using System;

namespace VideoStore
{
    class Program
    {
        public static readonly VideoStore store = new VideoStore();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to rate video");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        GiveRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            var _store = store.ListInventory();

            foreach(var video in _store)
            {
                Console.WriteLine(video.Title);
            }
        }

        private static void FillVideoStore()
        {
            store.AddVideo("The Matrix");
            store.AddVideo("Godfather II");
            store.AddVideo("Star Wars Episode IV: A New Hope");
        }

        private static void RentVideo()
        {
            Console.Write("Please enter desired movie title: ");
            var title = Console.ReadLine();
            var video = store.CheckOut(title);

            if(video == null)
            {
                Console.WriteLine($"Movie with title {title} is not available.");
            }
            else
            {
                Console.WriteLine($"Movie with title {title} is checked out.");
            }
        }

        private static void ReturnVideo()
        {
            Console.Write("Please enter movie title to return: ");
            var title = Console.ReadLine();

            store.Return(title);
        }

        public static void GiveRating(){
            Console.Write("Please enter movie title to rate: ");
            var title = Console.ReadLine();
            Console.Write("Please enter movie title to rate: ");
            var rating = double.Parse(Console.ReadLine());

            store.ReceiveRating(title, rating);
        }
    }
}
