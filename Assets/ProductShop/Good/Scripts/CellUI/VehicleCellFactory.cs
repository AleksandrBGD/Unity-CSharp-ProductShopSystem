using UnityEngine;

public class VehicleCellFactory : MonoBehaviour
{
    [SerializeField] private VehicleCell _prefab;
    [SerializeField] private Transform _parent;
    [SerializeField] private Dealership _dealership;

    public VehicleCell Get(ProductSerializable product)
    {
        var cell = Instantiate<VehicleCell>(_prefab, Vector3.zero, Quaternion.identity);
        cell.transform.SetParent(_parent);
        cell.Initialize(_dealership, product);

        return cell;
    }
}