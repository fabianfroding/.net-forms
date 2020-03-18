namespace MediaShop.Models
{
    class Product
    {
        public static int idCounter { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public int unitsSold { get; set; }
        public string dateSold { get; set; }
        public ProductType productType { get; set; }

        public Product()
        {
            idCounter++;
            this.id = idCounter;
        }

        public enum ProductType
        {
            BOOK,
            CD,
            DVD,
            GAME,
            OTHER
        }
    }
}
