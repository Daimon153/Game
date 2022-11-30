using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour, IInteractable
{
    public GameObject KeyOBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    public string GetDescription()
    {
        if (KeyOBJ)
        {
            return "Нажми E, чтобы взять ключ";

        }
        return "";
    }
    public void Interact()
    {
        if (KeyOBJ)
        {
            KeyOBJ.SetActive(false);
            SceneManager.LoadScene("Final");
        }

    }
}
