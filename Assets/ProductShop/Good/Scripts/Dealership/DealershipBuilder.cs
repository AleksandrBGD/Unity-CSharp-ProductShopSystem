using UnityEngine;

[RequireComponent(typeof(Dealership), typeof(DealershipUI))]
public class DealershipBuilder : MonoBehaviour
{
    [SerializeField] private ProductCollection _productsShop;

    [SerializeField] private Customer _customer;
    [SerializeField] private VehicleCellFactory _cellFactory;

    private Dealership _dealership;
    private DealershipUI _ui;
    private CellVehicleCollection _cellCollection;

    private void Awake()
    {
        _dealership = GetComponent<Dealership>();
        _ui = GetComponent<DealershipUI>();

        _cellCollection = new CellVehicleCollection(_customer.Purchases);

        Build();
    }

    public void Rebuild()
    {
        Clear();
        Build();
    }

    private void Build()
    {
        BuildCollections();
        BuildDealership();
        BuildDealershipUI();
    }

    private void Clear()
    {
        _cellCollection.Clear();
    }

    private void BuildCollections()
    {
        for (int i = 0; i < _productsShop.Count; i++)
        {
            var key = _productsShop.Keys[i];

            if (_cellCollection.ContainsKey(key)) return;

            var product = _productsShop.Products[i];
            var cell = _cellFactory.Get(product);

            _cellCollection.Add(key, cell);
        }
    }

    private void BuildDealership()
    {
        _dealership.Initialize(_ui, _customer);
    }

    private void BuildDealershipUI()
    {
        var firstProduct = _productsShop.DefaultProduct;
        _ui.Initialize(firstProduct, _cellCollection);
        _ui.Refresh();
    }
}