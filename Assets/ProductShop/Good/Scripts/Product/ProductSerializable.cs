using UnityEngine;

// Ключ продука - название машины, его можно поместить в данный класс.

[System.Serializable]
public class ProductSerializable
{
    [SerializeField] private Vehicle _vehicle;
    [SerializeField] [Range(0, 10000)] private int _price;

    public Vehicle Vehicle => _vehicle;
    public int Price => _price;
}