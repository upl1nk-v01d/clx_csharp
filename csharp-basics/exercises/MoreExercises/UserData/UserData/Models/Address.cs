﻿namespace UserData.Models
{
    public class Address
    {
        public string City { get; set; }
        public string StreetName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Coordinates Coordinates { get; set; }
    }
}