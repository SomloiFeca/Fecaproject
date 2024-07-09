using UnityEngine;

public class Circle : MonoBehaviour       // k�r
{
    [SerializeField] float radius;        // sug�r
    [SerializeField] float circumference; // ker�let
    [SerializeField] float area;          // ter�let

    void OnValidate()
    {
        circumference = (2 * radius) * Mathf.PI;
        area = (radius * radius) * Mathf.PI;        // Gyors

        area = Mathf.Pow(radius, 2) * Mathf.PI;     // Lass�

    }
}
