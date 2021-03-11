using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int wheelsOnCar = 4;


    void Start()
    {
        while (wheelsOnCar > 0)
        {
            Debug.Log("I cannot drive now!");
            wheelsOnCar--;
        }
    }
}
