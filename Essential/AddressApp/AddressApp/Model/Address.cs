namespace AddressApp.Model
{
    public class Address
    {
        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public string Index { get; set; }

        public string Country { get; set; }

        public  string City { get; set; }

        public string Street { get; set; }
        
        public string House { get; set; }

        public string Apartment { get; set; }

        public override string ToString()
        {
            return $"{nameof(Index)}: {Index}, {nameof(Country)}: {Country}, {nameof(City)}: {City}, {nameof(Street)}: {Street}, {nameof(House)}: {House}, {nameof(Apartment)}: {Apartment}";
        }
    }
}
