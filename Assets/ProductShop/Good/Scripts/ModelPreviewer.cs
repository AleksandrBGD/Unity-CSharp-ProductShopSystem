using UnityEngine;

public class ModelPreviewer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Vehicle _model;

    public void Show(ProductSerializable product)
    {
        _camera.gameObject.SetActive(true);

        _model?.gameObject.SetActive(false);
        _model = product.Vehicle;
        _model.gameObject.SetActive(true);
    }

    public void Hide()
    {
        _camera.gameObject.SetActive(false);
        _model?.gameObject.SetActive(false);
    }
}