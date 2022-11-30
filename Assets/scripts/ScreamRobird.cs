using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreamRobird : MonoBehaviour
{
    public bool _Scream;
    public AudioSource _source;
    public Animator _animator;
   

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _source = GetComponent<AudioSource>();
        _source.Stop();
        
    }

    void Update()
    {
        Anim();
       
        _source.loop = false; 
    }
    // Update is called once per frame
    void Anim()
    {
        _Scream = !_Scream;

        if (_Scream)
        {
            _animator.SetBool("_Scream", true);
             _source.Play();
            
              
            
            
        }
       
    }
   
}
