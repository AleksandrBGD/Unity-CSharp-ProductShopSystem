[System.Serializable]
public class CustomerDataSerializable
{
    public readonly string[] purchaseKeys;
    public readonly int money;

    public CustomerDataSerializable(string[] keys, int walletMoney)
    {
        purchaseKeys = keys;
        money = walletMoney;
    }
}