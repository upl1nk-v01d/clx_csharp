namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int column;
        private int rate;

        public NewspaperAd(int fee, int columnCm, int ratePerCm) : base(fee)
        {
            column = columnCm;
            rate = ratePerCm;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return fee + rate * column;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " Newspaper ad: column_cm =" + column
                   + " rate=" + rate;
        }
    }
}