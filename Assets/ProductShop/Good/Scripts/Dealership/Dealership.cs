using UnityEngine;

public class Dealership : MonoBehaviour
{
    [SerializeField] private ModelPreviewer _previewer;

    private DealershipUI _ui;
    private Customer _customer;

    public void Initialize(DealershipUI ui, Customer customer)
    {
        _ui = ui;
        _customer = customer;
    }

    public void Buy(ProductSerializable product)
    {
        var cashRegister = new CashRegister(product, _customer);

        if (!cashRegister.EnoughMoney) return;

        Preview(product);

        cashRegister.Pay();
        _ui.Refresh();
    }

    public void Preview(ProductSerializable product)
    {
        _previewer.Show(product);
    }
}