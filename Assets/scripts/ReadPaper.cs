using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPaper : MonoBehaviour
{
    public float distance;
    [SerializeField]
    private GameObject note;
    [SerializeField]
    private GameObject textNote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ReadNote()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, distance))
        {
            if (hit.collider.GetComponent<Paper>())
            {

            }
        }
    }

}
