using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private UnityEngine.AI.NavMeshAgent nav;
    public Animator _animator;
    public bool _Run;
    public bool _Walk;
    private bool alive=true;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive) { 
           nav.SetDestination(player.transform.position);
        }
       
    }
}
