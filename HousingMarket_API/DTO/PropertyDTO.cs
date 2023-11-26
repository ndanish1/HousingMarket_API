using HousingMarket_API.Model;

namespace HousingMarket_API.DTO
{
    public class PropertyDTO
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double SquareFootage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public PropertyDTO(PropertyModel property)
        {
            Type = property.Type;
            Address = property.Address;
            Bedrooms = property.Bedrooms;
            Bathrooms = property.Bathrooms;
            SquareFootage = property.SquareFootage;
            Price = property.Price;
            Description = property.Description;
        }
    }
}
