using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightflash : MonoBehaviour
{
    private float MinIntensive = 0.2f;
    private float MaxIntensive = 0.8f;


    void Start()
    {

    }


    void Update()
    {

        GetComponent<Light>().intensity = Random.Range(MinIntensive, MaxIntensive);

    }
}
