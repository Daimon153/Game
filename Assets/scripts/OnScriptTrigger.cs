using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScriptTrigger : MonoBehaviour
{
    public PaperUP paperScript;
    public GameObject Paper;
    public GameObject TextUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            TextUp.SetActive(true);
            paperScript.enabled=true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Paper.SetActive(false);
            TextUp.SetActive(false);
            paperScript.enabled = false;
        }
    }
}
