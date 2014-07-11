namespace FoursquareApi.Models.Common
{
    public class Link
    {
        public Provider Provider { get; set; }
        public string Url { get; set; }
        public string LinkedId { get; set; }
    }

    public class Provider
    {
        public string Id { get; set; }
    }
}
