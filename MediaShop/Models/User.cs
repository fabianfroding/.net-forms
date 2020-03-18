namespace MediaShop.Models
{
    class User
    {
        public string mail { get; set; }
        public string password { get; set; }
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
