/*
using System.Diagnostics;
using UnityEngine;

public class BoolPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void OnValidate()
    {
        bool b1 = true;
        bool b2 = false;

        int x = 21, y = 33;

        bool isXHigherThanY = x >= y;    // false
        bool isXLowerThanY = x >= y;     // true
        bool isXEqualToY = x == y;     // false
        bool isXNotEqualToY = x != y;     // true

        //-----------------------

        int ammo = 10;
        bool haveGun = true;
        bool haveAmmo = ammo > 0;

        bool canShoot = haveGun && haveAmmo;    // És mûvelet

        bool isGrounded = true;
        bool haveAirJump = false;

        bool canJump = isGrounded || haveAirJump;  // Vagy mûvelet

        bool a = true;
        bool b = true;
        bool c = a ^ b;

        int i = 10;
        int i2 = -i;        //-10

        bool d = !c;        //Nem

        //-----------------------

        int aa = 22, bb = 10;

        if (aa > b)
        {
            Debug.Log("A is higher!");
        }
        else if (bb > aa)
        {
            Debug.Log("B is higher!");
        }

        //------------------------

        int number = 123;

        if (number % 2 == 0))                   // Páros-e
        {
            Debug.Log("Páros");
        }
        else
        {
            Debug.Log("Páratlan");
        }

        //------

        int i = 1;

        while (i <= 5)
        {
            Debug.Log(i);
            i++;
        }
        for (int j = 1; j <= 5; j++)
        {
            Debug.Log(j);
        }




    }
        
    }
}
*/