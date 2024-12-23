using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class trace_player : MonoBehaviour
{
    private Agent_move moveAgent;
    public Transform target;
    private void Awake()
    {
        moveAgent = GetComponent<Agent_move>();
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
            
                moveAgent.MoveTo(target.position);
            
        //}
    }
}