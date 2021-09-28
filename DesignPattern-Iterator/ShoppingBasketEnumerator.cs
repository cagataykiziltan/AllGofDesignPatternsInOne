using System.Collections;

namespace DesignPattern_Iterator
{
    public class ShoppingBasketEnumerator : IEnumerator
    {
        private Product[] _productList;
        int _curentIndex = -1;

        public ShoppingBasketEnumerator(Product[] urunList)
        {
            _productList = urunList;
        }

        //iterasyonda kalinan yer.
        public object Current
        {
            get { return _productList[_curentIndex]; }
        }

        //bir sonraki adım var mi kontrolü.
        public bool MoveNext()
        {
            return ++_curentIndex < _productList.Length;
        }

        //iterasyonu basa alir.
        public void Reset()
        {
            _curentIndex = -1;
        }
    }
}
