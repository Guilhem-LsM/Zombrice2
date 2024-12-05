using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScriptEnemy : MonoBehaviour
{

    private NavMeshAgent agent;
    private Vector3 positionEnemy;
    private bool chase = false;

    private List<Vector3> positions = new List<Vector3>();
    private int index = 0;
    public GameObject player;

    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        positions.Add(new Vector3((float)-7.5, (float)1.06, (float)7.5));
        positions.Add(new Vector3((float)-7.5, (float)1.06, 3));
        positions.Add(new Vector3((float)-3.2, (float)5.64, (float)11.8));

    }



    void Update()
    {

        Debug.Log(transform.position + " ; " + positions[index] + " ; " + index + " ; " + (transform.position - positions[index]));

        if (Mathf.Abs((transform.position - positions[index]).x) < 0.01 && Mathf.Abs((transform.position - positions[index]).y) < 0.01 && Mathf.Abs((transform.position - positions[index]).z) < 0.01) 
        {

            index++;
            

            if (index == positions.Count) 
            { 
            
                index = 0;
            
            }

            

        }

        if (chase) 
        {

            agent.SetDestination(player.transform.position);

        }
        else 
        {

            agent.SetDestination(positions[index]);

        }

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            chase = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            chase = false;

        }

    }

}
