using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    // Start is called before the first frame update
    bool isLocked;
    void Start()
    {
        SetCursorLock(true);
    }
    void SetCursorLock(bool isLocked)
    {
        this.isLocked = isLocked;
        Cursor.visible = isLocked;
        Cursor.visible = !isLocked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SetCursorLock(!isLocked);
        }
    }
}
