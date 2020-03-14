namespace MediaShop.Models
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public Type type { get; set; }

        public Product()
        {
        }

        public enum Type
        {
            BOOK,
            CD,
            DVD,
            GAME,
            OTHER
        }
    }
}
