using UnityEngine;

public class Circle : MonoBehaviour       // kör
{
    [SerializeField] float radius;        // sugár
    [SerializeField] float circumference; // kerület
    [SerializeField] float area;          // terület

    void OnValidate()
    {
        circumference = (2 * radius) * Mathf.PI;
        area = (radius * radius) * Mathf.PI;        // Gyors

        area = Mathf.Pow(radius, 2) * Mathf.PI;     // Lassú

    }
}
