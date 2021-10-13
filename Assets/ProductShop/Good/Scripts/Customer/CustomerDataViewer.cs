using UnityEngine;
using UnityEngine.UI;

public class CustomerDataViewer : MonoBehaviour
{
    [SerializeField] private Text _moneyOutput;
    [SerializeField] private Customer _customer;

    public void Refresh()
    {
        _moneyOutput.text = _customer.Wallet.Money.ToString();
    }
}