namespace AdApp
{
    public abstract class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _copies;
        private int _costPerCopy;
    
        public Poster(int fee, int width, int height, int copies, int costPerCopy) : base(fee) 
        {
            _width = width;
            _height = height;
            _copies = copies;
            _costPerCopy = costPerCopy;
        }
    }
}
