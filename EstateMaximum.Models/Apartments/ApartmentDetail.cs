namespace EstateMaximum.Models.Apartments
{
    public class ApartmentDetail
    {
       
        public int ApartmentId { get; set; }

        public string ApartmentName { get; set; }

        public string Address { get; set; }

        public string City { get; set; } = string.Empty;

        public int ApartmentNumber { get; set; }
        
        public string Description { get; set; }

        public string Size { get; set; }
        
        public double Price { get; set; }
        
        public int Bedrooms { get; set; }
        
        public int Bathrooms { get; set; }

        public bool Gym { get; set; }
        public bool Pool { get; set; }
        public DateTimeOffset DatePosted { get; set; }

    }
}
