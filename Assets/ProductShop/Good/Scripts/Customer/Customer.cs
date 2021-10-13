using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private WalletSerializable _wallet;
    [SerializeField] private PurchasesCollection _purchases;

    public WalletSerializable Wallet => _wallet;
    public PurchasesCollection Purchases => _purchases;
}