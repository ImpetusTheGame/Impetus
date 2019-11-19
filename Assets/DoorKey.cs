using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    public bool inTrigger;
    

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
    private void Update()
    {
        if (inTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                OpenTheDoor.doorKey = true;                  
                Destroy(this.gameObject);
            }
        }
           }

    void OnGUI()
    {
        if(inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Pressione E para pegar a chave");
        }
    }
}
