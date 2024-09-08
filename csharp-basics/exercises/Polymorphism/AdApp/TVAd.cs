namespace AdApp
{
    public class TVAd : Advert
    {
        private int _airTime;
        private int _cost;
        private bool _doubling;
        public TVAd(int fee, int airTime, int cost, bool doubling) : base(fee)
        {
            _airTime = airTime;
            _cost = cost;
            _doubling = doubling;
        }
        
        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}