namespace AdApp
{
    public class Advert
    {
        protected int _fee;

        public Advert() 
        {
            _fee = 0;
        }

        public Advert(int fee) 
        {
            _fee = fee;
        }

        public void SetFee(int fee) 
        {
            _fee = fee;
        }

        public int Cost() 
        {
            return _fee;
        }

        public override string ToString() 
        {
            return $"Advert: {this.GetType().Name} fee = {_fee}";
        }
    }
}