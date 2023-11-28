using System.Runtime.InteropServices;

namespace HousingMarket_API.Model
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string? PropertyType { get; set; }
        public string? PropertyAddress { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int SquareFootage { get; set; }
        public decimal Price { get; set; }
        public string? PropertyDescription { get; set; }

        public PropertyModel(string propertyType, string propertyAddress, int bedrooms, int bathrooms, int squareFootage, decimal price, string propertyDescription)
        {
            PropertyType = propertyType;
            PropertyAddress = propertyAddress;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            SquareFootage = squareFootage;
            Price = price;
            PropertyDescription = propertyDescription;
        }

        /*public void DisplayDetails()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Bedrooms: {Bedrooms}");
            Console.WriteLine($"Bathrooms: {Bathrooms}");
            Console.WriteLine($"Square Footage: {SquareFootage} sq.ft");
            Console.WriteLine($"Price: ${Price:N0}");
            Console.WriteLine($"Description: {Description}");
        }*/

    }
}
