namespace AdApp
{
    public class TVAd : Advert
    {
        private int _airTime;
        private int _views;
        private int _cpm;
        private bool _peak;

        public TVAd(int fee, int views, int airTime, bool peak) : base(fee)
        {
            this._airTime = airTime;
            this._views = views;
            this._cpm = 5; //$5 per 1,000 impressions (CPM).
            this._peak = peak;

            this._fee = fee * airTime + views * this._cpm;
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