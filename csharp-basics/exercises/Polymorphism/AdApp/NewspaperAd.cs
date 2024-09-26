using System;

namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int columns, int size, int rate) : base(fee)
        {
            this._column = columns;
            this._rate = rate;
            
            this._fee = fee * columns * size;
            this._fee += Convert.ToInt32(this._fee * (rate * 0.01));
        }

        public override int Cost()
        {
            return this._fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}