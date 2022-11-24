using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class List : MonoBehaviour, IInteractable
{
   
    public GameObject Flaer;
    
  //  public bool fl = 
    // Start is called before the first frame update
    public void Start()
    {
        Flaer.SetActive(false);
   
    }

    public string GetDescription()
    {
        if (Flaer)
        {
            return "Нажми E, чтобы повесить рекламу";
        }
        else { 
        return "Реклама повешена"; }
    }
    // Update is called once per frame
    public void Interact()
    {
        if (Flaer)
        {
            Flaer.SetActive(true);
        }

    }

}

