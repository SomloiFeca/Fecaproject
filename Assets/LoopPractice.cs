using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 100; i >= 1; i--)
        {
            Debug.Log(i);
        }

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 ==0 || i % 5 ==0)
            {
                Debug.Log(i);
            }
        }
    }

   
}
