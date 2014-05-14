using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexAPI.Maps
{
    public class Address
    {
        private string _addressLine = String.Empty;
        private string _countryNameCode = String.Empty;
        private string _countryName = String.Empty;

        public Address()
        {

        }

        public Address(string addressLine, string countryNameCode, string countryName)
        {
            AddressLine = addressLine;
            CountryName = countryName;
            CountryNameCode = countryNameCode;
        }

        public string AddressLine
        {
            get { return _addressLine; }
            set { _addressLine = value; }
        }

        public string CountryNameCode
        {
            get { return _countryNameCode; }
            set { _countryNameCode = value; }
        }

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        public override string ToString()
        {
            return String.Join(", ", CountryName, AddressLine);
        }
    }
}
