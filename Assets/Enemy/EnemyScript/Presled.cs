using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presled : MonoBehaviour
{
    private Transform Player;
    private UnityEngine.AI.NavMeshAgent NMA;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        NMA = (UnityEngine.AI.NavMeshAgent)this.GetComponent("NavMeshAgent");
    }

    // Update is called once per frame
    void Update()
    {
        NMA.SetDestination(Player.position);
    }
}
