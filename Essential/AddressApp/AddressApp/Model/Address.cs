namespace AddressApp.Model
{
    public class Address
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _house = house;
            _apartment = apartment;
        }

        public Address()
        {
            Index = "03058";
            Country = "Ukraine";
            City = "Kiev";
            Street = "Kreschatik";
            House = "1/1";
            Apartment = "5";
        }

        public string Index { get; set; }

        public string Country { get; set; }

        public  string City { get; set; }

        public string Street { get; set; }
        
        public string House { get; set; }

        public string Apartment { get; set; }
    }
}
