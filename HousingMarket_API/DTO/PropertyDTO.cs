using HousingMarket_API.Model;

namespace HousingMarket_API.DTO
{
    public class PropertyDTO
    {
        public int Id { get; set; }
        public string? PropertyType { get; set; }
        public string? PropertyAddress { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int SquareFootage { get; set; }
        public decimal Price { get; set; }
        public string? PropertyDescription { get; set; }

        public PropertyDTO() { }
        public PropertyDTO(PropertyModel property)
        {
            PropertyType = property.PropertyType;
            PropertyAddress = property.PropertyAddress;
            Bedrooms = property.Bedrooms;
            Bathrooms = property.Bathrooms;
            SquareFootage = property.SquareFootage;
            Price = property.Price;
            PropertyDescription = property.PropertyDescription;
        }
    }
}
