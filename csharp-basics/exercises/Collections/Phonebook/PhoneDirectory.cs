using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> PhoneEntries = new SortedDictionary<string, string>();

        private int _dataCount;

        public PhoneDirectory() {
            _dataCount = PhoneEntries.Count;
        }

        private string Find(string name) 
        {
            foreach(var key in PhoneEntries)
            {
                if (key.Key == name) 
                {
                    return key.Key;
                }
            }

            return null;
        }

        public string GetNumber(string name) 
        {
            foreach(var key in PhoneEntries)
            {
                if (key.Key == name) 
                {
                    return key.Value;
                }
            }

            return null;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
            
            var key = Find(name);

            if (key != null) 
            {
                PhoneEntries[key] = number;
            }
            else 
            {
                PhoneEntries.Add(name, number);
            }

            _dataCount = PhoneEntries.Count;
        }

        public int GetDataCount()
        {
            return _dataCount;
        }
    }
}