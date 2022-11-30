using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presled : MonoBehaviour
{
    private Transform Player;
    private UnityEngine.AI.NavMeshAgent NMA;
    public Animator _animator;
    public bool _Run;
    public bool _Walk;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        NMA = (UnityEngine.AI.NavMeshAgent)this.GetComponent("NavMeshAgent");
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        _Walk = !_Walk;
        _Run = !_Run;
        if (_Walk) {
            _animator.SetBool("_Walk", true);
            NMA.SetDestination(Player.position);

        }
    }
}
