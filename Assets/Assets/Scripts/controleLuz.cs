using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleLuz : MonoBehaviour
{
    public Light luz;
    public float duracaoLuz = 437.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        luz.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (luz.enabled == false)
            {
                luz.enabled = true;
            }
            else
            {
                luz.enabled = false;
            }
        }
        if (luz.enabled == true)
        {
            duracaoLuz -= 0.08f;
            luz.intensity -= 0.00008f;
        }
        if (duracaoLuz <= 0)
        {
            luz.enabled = false;
            duracaoLuz = 0;
            luz.intensity = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            duracaoLuz += 100f;
            luz.intensity += 0.05f;
        }
        if (duracaoLuz >= 1000f)
        {
            duracaoLuz = 1000f;
        }
        if (luz.intensity >= 1)
        {
            luz.intensity = 1;
        }
    }
}
