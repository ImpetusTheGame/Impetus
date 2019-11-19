using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public int waitTime;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("GameScene");
    }
   
}
