using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kyaku2Move : MonoBehaviour
{
    private NavMeshAgent agent;
    
    [SerializeField]
    private GameObject target;


    void Start()
    {
        target = GameObject.Find("Target2");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="target2")
        {
            Destroy(this.gameObject);
            GameController.k2count += 1;
            // Debug.Log(GameController.k2count);
        }
    }
}
