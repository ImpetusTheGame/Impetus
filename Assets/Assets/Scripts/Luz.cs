using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{

    public Light luz;
  
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            luz.enabled = !luz.enabled;
        }

    }
}
