namespace ExercicioPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        private double Total { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $" + Total.ToString("F2") + $" (Customs fee: ${CustomsFee.ToString("F2")})";
        }

        public void TotalPrice()
        {
             Total = Price + CustomsFee;
        }
    }
}
