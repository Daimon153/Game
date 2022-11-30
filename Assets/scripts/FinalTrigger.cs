using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FinalTrigger : MonoBehaviour
{
    public bool KeyOBJ;
    public GameObject dor;
	public GameObject Key2;
    public void Start()
    {
        KeyOBJ = GetComponent<Key>();
        
    }


	public string GetDescription()
	{
		if (dor)
		{
			return "";

		}
		return "Нажми E, чтобы открыть дверь ключом";
	}
	public void Interact()
	{
		

		if (dor&&Key2)
		{
			SceneManager.LoadScene("Final");
		}

		
	}
}
