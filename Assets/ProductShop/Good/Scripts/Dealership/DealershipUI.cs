using UnityEngine;

public class DealershipUI : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Camera _camera;
    [SerializeField] private ModelPreviewer _previewer;
    [SerializeField] private CustomerDataViewer _customerDataViewer;

    private CellVehicleCollection _cellCollection;
    private ProductSerializable _defaultProduct;

    public void Initialize(ProductSerializable defaultProduct, CellVehicleCollection cellCollection)
    {
        _defaultProduct = defaultProduct;
        _cellCollection = cellCollection;
    }

    public void Enable()
    {
        _panel.SetActive(true);
        _camera.gameObject.SetActive(false);

        _previewer.Show(_defaultProduct);
        Refresh();
    }

    public void Refresh()
    {
        _cellCollection.Refresh();
        _customerDataViewer.Refresh();
    }

    public void Disable()
    {
        _panel.SetActive(false);
        _camera.gameObject.SetActive(true);

        _previewer.Hide();
    }
}