using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
}
