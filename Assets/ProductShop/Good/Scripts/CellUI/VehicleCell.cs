using UnityEngine;
using UnityEngine.UI;

public class VehicleCell : MonoBehaviour
{
    [SerializeField] private Button _buy, _preview;
    [SerializeField] private Text _nameOutput, _priceOutput;

    private Dealership _dealership;
    private ProductSerializable _product;

    public void Initialize(Dealership dealership, ProductSerializable product)
    {
        _dealership = dealership;
        _product = product;

        _buy.onClick.AddListener(OnBuy);
        _preview.onClick.AddListener(OnPreview);

        Refresh();
    }

    public void ShowBuyButtons()
    {
        _buy.gameObject.SetActive(true);
        _priceOutput.gameObject.SetActive(true);
    }

    public void HideBuyButtons()
    {
        _buy.gameObject.SetActive(false);
        _priceOutput.gameObject.SetActive(false);

        _buy.onClick.RemoveListener(OnBuy);
    }

    private void OnBuy()
    {
        _dealership?.Buy(_product);
    }

    private void OnPreview()
    {
        _dealership?.Preview(_product);
    }

    private void Refresh()
    {
        _nameOutput.text = _product.Vehicle.Name;
        _priceOutput.text = _product.Price.ToString();
    }
}