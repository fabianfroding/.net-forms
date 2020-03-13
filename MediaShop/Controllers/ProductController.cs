using MediaShop.Repositories;

namespace MediaShop
{
    class ProductController
    {
        private ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }
    }
}
