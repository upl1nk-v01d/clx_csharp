namespace AdApp
{
    public abstract class Advert
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

        public abstract int Cost();

        public override string ToString() 
        {
            return $"Advert: {this.GetType().Name} fee = {_fee}";
        }
    }
}