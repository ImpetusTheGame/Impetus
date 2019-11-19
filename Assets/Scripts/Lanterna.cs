using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    bool liga;

    void Start()
    {
        liga = true;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            liga = false;
        }

        if (liga == true)
        {
            
        }
    }
}
