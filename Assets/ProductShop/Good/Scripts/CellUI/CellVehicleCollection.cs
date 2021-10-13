using System.Collections.Generic;
using UnityEngine;

public class CellVehicleCollection
{
    private readonly PurchasesCollection _purchases;
    private readonly Dictionary<string, VehicleCell> _cellDictionary = new Dictionary<string, VehicleCell>();

    public CellVehicleCollection(PurchasesCollection purchases)
    {
        _purchases = purchases;
    }

    public bool ContainsKey(string key) => _cellDictionary.ContainsKey(key);

    public void Add(string key, VehicleCell cell)
    {
        _cellDictionary.Add(key, cell);
        _cellDictionary[key].ShowBuyButtons();
    }

    public void Refresh()
    {
        foreach (var cell in _cellDictionary)
        {
            var vehicleCell = cell.Value;
            vehicleCell.ShowBuyButtons();
        }

        for (int i = 0; i < _purchases.Keys.Length; i++)
        {
            var key = _purchases.Keys[i];

            if (_cellDictionary.ContainsKey(key))
                _cellDictionary[key].HideBuyButtons();
        }
    }

    public void Clear()
    {
        foreach (var item in _cellDictionary)
        {
            GameObject obj = item.Value.gameObject;
            GameObject.Destroy(obj);
        }

        _cellDictionary.Clear();
    }
}