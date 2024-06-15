using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    public GameObject target; //이동할 목표 지점
    NavMeshAgent agent;
    LineRenderer lr; //경로

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        lr = this.GetComponent<LineRenderer>();
        lr.startWidth = lr.endWidth = 10;
        lr.material.color= Color.red;
        lr.enabled = false ; //초기 비활성화

        StartCoroutine(StartPathAfterDelay(4.0f));
    }

    IEnumerator StartPathAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // delay 만큼 대기
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

