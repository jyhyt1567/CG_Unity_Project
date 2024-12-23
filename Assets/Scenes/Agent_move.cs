using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Agent_move : MonoBehaviour
{
    [SerializeField]
    private float move_speed = 5.0f;
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public void MoveTo(Vector3 pos)
    {
        agent.speed = move_speed;
        agent.SetDestination(pos);
        StartCoroutine("OnMove");
    }
    IEnumerator OnMove()
    {
        while (true)
        {
            if (Vector3.Distance(agent.destination, transform.position) < 0.1f)
            {
                transform.position = agent.destination;
                agent.ResetPath();
                break;
            }

            yield return null;
        }
    }
}