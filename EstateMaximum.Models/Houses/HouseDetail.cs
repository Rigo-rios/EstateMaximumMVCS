namespace EstateMaximum.Models.Houses
{
    public class HouseDetail
    {
        public int Id { get; set; }

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int HouseNumber { get; set; }

        public double Price { get; set; }

        public string Size { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public int Stories { get; set; }

        public DateTimeOffset DatePosted { get; set; }
    }
}
