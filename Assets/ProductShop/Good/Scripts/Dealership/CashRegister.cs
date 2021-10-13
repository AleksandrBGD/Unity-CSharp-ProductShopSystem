public class CashRegister
{
    private readonly ProductSerializable _product;
    private readonly Customer _customer;

    public CashRegister(ProductSerializable product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }

    public bool EnoughMoney => Money >= _product.Price;

    private int Money { get => _customer.Wallet.Money; set => _customer.Wallet.Money = value; }

    public void Pay()
    {
        Money -= _product.Price;
        _customer.Purchases.Add(_product);
    }
}