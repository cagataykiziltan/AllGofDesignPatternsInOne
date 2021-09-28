using System.Collections;

namespace DesignPattern_Iterator
{
    public class ShoppingBasket : IEnumerable
    {

        public Product[] _productlist { get; set; }

        public ShoppingBasket()
        {
            _productlist = new Product[]
           {
             new Product(){ Name="Computer", Price=1022.3m},
             new Product(){ Name="Ipad", Price=699.9m}
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new ShoppingBasketEnumerator(_productlist);
        }
    }

}
