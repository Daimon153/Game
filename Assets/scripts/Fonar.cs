using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonar : MonoBehaviour
{
    public Light fonar;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(fonar.enabled == false)
            {
                fonar.enabled = true;
            }
            else
            {
                fonar.enabled = false;
            }
        }
    }
}
