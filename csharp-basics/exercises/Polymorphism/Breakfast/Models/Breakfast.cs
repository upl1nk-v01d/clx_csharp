using System.Threading.Channels;

namespace Breakfast.Models
{
    public class Breakfast
    {
        public Coffee Coffee { get; set; } = new Coffee();
        public Bacon Bacon { get; set; } = new Bacon();
        public Egg Egg { get; set; } = new Egg();
        public Juice Juice { get; set; } = new Juice();
    }
}
