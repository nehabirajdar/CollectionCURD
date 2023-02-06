using System.Collections.Generic;

namespace CollectionCURD
{
    public class ProductCRUD
    {
        private List<Product> products;
        public ProductCRUD()
        {
            products = new List<Product>()
            {
                new Product{Id=101,Name="Connector",Price=799},
                new Product{Id=102,Name="Pendrive",Price=999},
            };
        }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }
        public void UpdateProduct(Product prod)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == prod.Id)
                {
                    products[i].Name = prod.Name;
                    products[i].Price = prod.Price;
                    break; // to break the loop
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
        }
        public List<Product> List()
        {
            return products;
        }

    }
}
