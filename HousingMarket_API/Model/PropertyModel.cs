using System.Runtime.InteropServices;

namespace HousingMarket_API.Model
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double SquareFootage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public PropertyModel(string type, string address, int bedrooms, int bathrooms, double squareFootage, decimal price, string description)
        {
            Type = type;
            Address = address;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            SquareFootage = squareFootage;
            Price = price;
            Description = description;
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
