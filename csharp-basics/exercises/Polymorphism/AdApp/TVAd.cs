namespace AdApp
{
    public class TVAd: Advert
    {
        private int sec;
        private int rate;
        private bool peak;

        public TVAd(int fee, int sec, int rate, bool peak) : base(fee)
        {
            this.sec = sec;
            this.rate = rate;
            this.peak = peak;
        }
        
        public new int Cost() {
            return base.Cost() + sec * (peak ? rate * 2 : rate);
        }

        public override string ToString() {
            return base.ToString()  + " TV ad: length= " + sec + " secs."
                   + " Rate=" + (peak ? rate * 2 : rate);
        }
    }
}