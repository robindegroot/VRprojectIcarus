using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private AudioSource source;
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private bool patrol = true;
    public Transform Player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GotoNextPoint();
        Debug.Log("patrolling");
      
    }


    void GotoNextPoint()
    {
        if (patrol == true)
        {
            AudioSource source = GetComponent<AudioSource>();
            if (points.Length == 0)
                return;
            agent.destination = points[destPoint].transform.position;
            destPoint = (destPoint + 1) % points.Length;
            source.Play();
            source.loop = true;
        }
    }

    void Update()
    {
        if (agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("waaaaaaah!");
            GetComponent<NavMeshAgent>().destination = Player.position;
            patrol = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            patrol = true;
        }
    }
}