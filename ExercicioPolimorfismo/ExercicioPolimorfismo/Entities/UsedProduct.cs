using System;

namespace ExercicioPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name,price) 
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (Used) $" + Price + $" (Manufacutre date: {ManufactureDate.ToString("dd/MM/yyyy")})" ;
        }
    }
}
