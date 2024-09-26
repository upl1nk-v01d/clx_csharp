using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private string _name;
        
        private List<Advert> _campaign;

        public Campaign(string name) 
        {
            this._campaign = new List<Advert>();
            this._name = name;
        }

        public void AddAdvert(Advert advert) 
        {
            this._campaign.Add(advert);
            Console.WriteLine(advert);
        }

        public int GetCost()
        {
            int sum = this._campaign.Sum(item => item.Cost());

            return sum;
        }

        public override string ToString()
        {
            return $"Advert campaign '{this._name}' total cost = {this.GetCost()}";
        }
    }
}