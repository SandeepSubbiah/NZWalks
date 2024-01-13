namespace NZWalks.API.Models.DTO
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
    }
}
