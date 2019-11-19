using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;

    }
    void Update()
    {
        if(inTrigger)
        {
            if (close)
            {
                if (doorKey)//Para as outras portas desabilita isso aki
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if(inTrigger)
        {
            if(open)
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 180.0f, 0.0f), Time.deltaTime + 0.5f);
                transform.rotation = newRot;
            }
            else
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime + 0.5f);
                transform.rotation = newRot;
            }
        }
    }

    void OnGUI()
    {
        if(inTrigger)
        {
            if(open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Pressione E para Fechar");
            }
            else
            {
               if(doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Pressione E para Abrir");
                }
               else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Precisa da Chave");
                }
            }
        }
    }
}

