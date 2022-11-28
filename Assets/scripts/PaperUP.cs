using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperUP : MonoBehaviour
{
    public Text txt;
    public string PaperText;
    public GameObject Paper;
    public GameObject TextUp;
    private bool UpPaper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (UpPaper == false)
            {
               
                Paper.SetActive(true);
                txt.text = null;
                txt.text = PaperText;
                TextUp.SetActive(false);
                UpPaper = true;
            }
            else
            {
               
                Paper.SetActive(false);
                txt.text = null;
                UpPaper = false;
            }
        }
    }
}
