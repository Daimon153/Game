using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_Control : MonoBehaviour
{
   
    public float speed = 0.1f;//скорость
    public float run = 6f;//бег
    public bool ground;
    public AudioSource _source;
    CharacterController player;
    private RaycastHit _hit;





    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        _source= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        
    GetInput();
      
      
        
    }
   
    private void GetInput()
    {

      
        if (Input.GetKey(KeyCode.W))//хождение вперёд
        {
            
            transform.localPosition += transform.forward*speed* Time.deltaTime;
            if (!_source.isPlaying)//включение звука ходьбы
                {
                    _source.Play();
                }
           
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.forward * run * Time.deltaTime;
                
            }
        }
        else
        {
            if (_source.isPlaying)//выключение звука ходьбы
            {
                _source.Stop();
            }
        }
        
        if (Input.GetKey(KeyCode.S))//хождение назад
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += -transform.forward * run * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))//хождение влево
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += -transform.right * run * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))//хождение вправо
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localPosition += transform.right * run * Time.deltaTime;
            }
        }
       // if(_hit.transform != null && _hit.transform.GetComponent<door>()) { 
       // if (Input.GetKeyDown(KeyCode.E))
       // {
      //      _hit.transform.GetComponent<door>().Open();
      //  }
       //   }

    }
   
 
}
