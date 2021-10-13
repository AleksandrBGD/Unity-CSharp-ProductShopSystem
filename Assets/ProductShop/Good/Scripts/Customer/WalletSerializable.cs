using UnityEngine;

[System.Serializable]
public class WalletSerializable
{
    [SerializeField] [Range(0, 100000)] private int _money;

    public int Money
    {
        get => _money;
        set
        {
            _money = value;
            _money = Mathf.Clamp(_money, 0, 100000);
        }
    }
}