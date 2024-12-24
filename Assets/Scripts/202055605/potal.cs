using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_dungeon : MonoBehaviour
{
    //public GameManager manager;
    public GameObject enterPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            //manager.TermProject_Dungeon_start();
            other.gameObject.transform.position = enterPoint.transform.position;
    }
}
