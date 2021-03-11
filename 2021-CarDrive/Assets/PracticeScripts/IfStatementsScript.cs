using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementsScript : MonoBehaviour
{
    float engineTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        engineTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        
        if (engineTemperature > hotLimitTemperature)
        {
           
            print("Cars explodin bye.");
        }
        
        else if (engineTemperature < coldLimitTemperature)
        {
            
            print("You are totally gonna freeze up boy.");
        }
        
        else
        {
            
            print("Youre fine keep goin.");
        }
    }
}
