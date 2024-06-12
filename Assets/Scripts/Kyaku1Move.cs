using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kyaku1Move : MonoBehaviour
{
    private NavMeshAgent agent;
    
    [SerializeField]
    private GameObject target;

    void Start()
    {
        target = GameObject.Find("Target1");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="target1")
        {
            Destroy(this.gameObject);
            GameController.k1count += 1;
        }
    }
}
