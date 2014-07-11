namespace FoursquareApi.Models.Common
{
    public class Location
    {
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Distance { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
