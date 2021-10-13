public class PurchasesCollection : ProductCollection
{
    public void Add(ProductSerializable product)
    {
        _products.Add(product);
    }

    public void Clear()
    {
        _products.Clear();
    }
}