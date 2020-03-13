namespace MediaShop.Models
{
    class User
    {
        public int id { get; set; }
        public string mail { get; set; }
        public Department department { get; set; }

        public User()
        {
        }

        public enum Department
        {
            SALES,
            STORAGE
        }
    }
}
