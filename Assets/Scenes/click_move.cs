using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class click_move : MonoBehaviour
{
    private Agent_move moveAgent;
    private void Awake()
    {
        moveAgent = GetComponent<Agent_move>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                moveAgent.MoveTo(hit.point);
            }
        }
    }
}