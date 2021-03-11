using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numEnemies = 3;

        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

}
