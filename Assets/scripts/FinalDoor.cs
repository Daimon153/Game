using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FinalDoor : MonoBehaviour { 
    public bool _isOpened;
    public Animator _animator;
    public bool Fl;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        Fl=GetComponent<List>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Fl)
        {
            _animator.SetBool("_isOpened", false);
        }
        else
        {
            _animator.SetBool("_isOpened", true);
        }
        
    }
}
