namespace AzureRegionMapApp.Models
{
    public class AzureRegion
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Geography { get; set; }
        public string RegionCode { get; set; }
        public bool HasAvailabilityZones { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
