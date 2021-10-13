using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private string _name;

    public string Name => _name;
}