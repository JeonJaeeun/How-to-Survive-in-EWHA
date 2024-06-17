using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PathFinder : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    LineRenderer lr;

    void Start()
    {
        if(InsideSceneManager.manager.CheckIsNavigationEnd())
        {
            this.transform.position = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
            return;
        }

        agent = this.GetComponent<NavMeshAgent>();

        lr = this.GetComponent<LineRenderer>();
        lr.startWidth = lr.endWidth = 10;
        lr.material.color= Color.red;
        lr.enabled = false ;

        StartCoroutine(StartPathAfterDelay(4.0f));
    }

    IEnumerator StartPathAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        makePath();
    }
    public void makePath()
    {
        lr.enabled= true ;
        StartCoroutine(makePathCoroutine());
    }

    void drawPath()
    {
        int length = agent.path.corners.Length;

        lr.positionCount = length;
        for(int i = 1; i < length; i++)
            lr.SetPosition(i, agent.path.corners[i]);
    }

    IEnumerator makePathCoroutine()
    {
        agent.SetDestination(target.transform.position);
        lr.SetPosition(0, this.transform.position);

        while (Vector3.Distance(this.transform.position, target.transform.position) > 0.1f)
        {
            lr.SetPosition(0, this.transform.position);

            drawPath();

            yield return null;
        }

        lr.enabled = false;
      }
    }

