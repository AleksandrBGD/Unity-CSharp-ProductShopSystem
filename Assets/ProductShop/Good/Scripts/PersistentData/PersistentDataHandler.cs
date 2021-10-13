using UnityEngine;

public class PersistentDataHandler : MonoBehaviour
{
    [SerializeField] private ProductCollection _productsShop;
    [SerializeField] private Customer _customer;

    private readonly PersistentData _persistentData = new PersistentData();

    public void OnSave()
    {
        _persistentData.Save(_customer);
        print("Save");
    }

    public void OnLoad()
    {
        if (!_persistentData.DataFileExists) return;

        _customer.Purchases.Clear();
        
        var customerData = _persistentData.Load();
        _customer.Wallet.Money = customerData.money;

        for (int i = 0; i < customerData.purchaseKeys.Length; i++)
        {
            for (int y = 0; y < _productsShop.Products.Length; y++)
            {
                if (_productsShop.Keys[y] == customerData.purchaseKeys[i])
                {
                    var product = _productsShop.Products[y];
                    _customer.Purchases.Add(product);
                    break;
                }
            }
        }

        print("Load");
    }
}