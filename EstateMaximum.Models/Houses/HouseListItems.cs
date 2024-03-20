namespace EstateMaximum.Models.Houses
{
    public class HouseListItems
    {
        public int Id { get; set; }

        public string City { get; set; } = string.Empty;

        public int HouseNumber { get; set; }
        public DateTimeOffset DatePosted { get; set; }
    }
}
