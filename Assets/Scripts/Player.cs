using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using TMPro;

public class Player : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    GameObject GoalObj;
    
    [SerializeField] private GameObject hitoObj;
    [SerializeField] private TextMeshPro target_num;
    private int goal_number;

    void Start()
    {
        goal_number = Random.Range(0, 4);
        Debug.Log("GoalNumber: " + goal_number);
        Player_Nav = GetComponent<NavMeshAgent>();
        GoalObj = GameObject.Find("Goal" + goal_number);

        target_num = hitoObj.GetComponent<TextMeshPro>();
    
        // テキストに目標番号を表示
        target_num.text = goal_number.ToString();
    }

    void Update()
    {
        if (GoalObj != null)
        {
            Player_Nav.SetDestination(GoalObj.transform.position);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Goal")
        {
            Destroy(this.gameObject);
            // Debug.Log("当たった");
        }
    }
}
