namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long Area { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public long Population { get; set; }

        // Navigation Property
        public IEnumerable<Walk> Walks { get; set; }

        public static explicit operator double(Region v)
        {
            throw new NotImplementedException();
        }
    }
}
