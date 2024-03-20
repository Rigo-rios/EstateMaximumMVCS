namespace EstateMaximum.Models.Apartments
{
    public class ApartmentListItem
    {
        public int ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public string City { get; set; } = string.Empty;
        
        public int ApartmentNumber { get; set; }
        public double Price { get; set; }
        public DateTimeOffset DatePosted { get; set; }
    }
}
