using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Ineraktive : MonoBehaviour
{
    public Camera mainCam;
    public float interDistance = 1f;
    public GameObject interUI;
    public TextMeshProUGUI interText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InterRay();
    }
    void InterRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 3f);
        RaycastHit hit;
        bool hitSomething=false;
        if(Physics.Raycast(ray, out hit, interDistance))
        {
            IInteractable interact = hit.collider.GetComponent<IInteractable>();
            if(interact != null)
            {
                hitSomething=true;
                interText.text = interact.GetDescription();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interact.Interact();
                }
            }

        }
        interUI.SetActive(hitSomething);
    }
}
