using System.Collections.Generic;
using UnityEngine;

public class ProductCollection : MonoBehaviour
{
    [SerializeField] protected List<ProductSerializable> _products = new List<ProductSerializable>();

    public string[] Keys
    {
        get
        {
            var keys = new string[_products.Count];

            for (int i = 0; i < _products.Count; i++)
            {
                keys[i] = _products[i].Vehicle.Name;
            }

            return keys;
        }
    }

    public int Count => Keys.Length;
    public ProductSerializable[] Products => _products.ToArray();
    public ProductSerializable DefaultProduct => _products[0];
}