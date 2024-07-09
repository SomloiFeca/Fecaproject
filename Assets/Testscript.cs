using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

class TestScript : MonoBehaviour
{
    [SerializeField] float a = 10;
    [SerializeField] float b = 10;
    [SerializeField] float power;
    [SerializeField] float minimum;
    [SerializeField] float maximum;
    [SerializeField] float abs;
    [SerializeField] float sign;
    [SerializeField] float clamp;
    [SerializeField] float sqrt;
    [SerializeField] float ceil;
    [SerializeField] float floor;
    [SerializeField] float round;

    void OnValidate()
    {
        power = Mathf.Pow(a, b);
        minimum = Mathf.Min(a, b);
        maximum = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        sign = Mathf.Sign(a);
        clamp = Mathf.Clamp(a, -100, 100);
        sqrt = Mathf.Sqrt(a);
        ceil = Mathf.Ceil(a);
        floor = Mathf.Floor(a);

    }
}
