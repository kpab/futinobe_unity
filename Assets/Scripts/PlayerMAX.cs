using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using TMPro;

public class PlayerMAX : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    public static GameObject GoalObj;
    GameObject[] targets;
    [SerializeField] private TextMeshPro target_num;
    private int goal_number;
    [SerializeField] private GameObject hitoObj;


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
        target_num.text = GoalObj.name[GoalObj.name.Length - 1].ToString();
        if (GoalObj != null)
        {
            Player_Nav.SetDestination(GoalObj.transform.position);
        }
    }

    void OnTriggerExit(Collider ob)
    {
        //  Debug.Log("何かを通過");
        if(ob.gameObject.tag=="chkPoint")
        {
            // Debug.Log("chkpointを通過");
            string nextGoal = FindMinVariable(konzatu.chk0, konzatu.chk1, konzatu.chk2, konzatu.chk3);
            if(nextGoal!="none")
            {
                GoalObj = GameObject.Find(nextGoal);
            }
        }
    }
    private string FindMinVariable(int v0, int v1, int v2, int v3)
    {
        int minValue = Mathf.Min(v0, v1, v2, v3);
        if(minValue>0)
        {
            if (minValue == v3) return "Goal3";
            if (minValue == v2) return "Goal2";
            if (minValue == v1) return "Goal1";
            if (minValue == v0) return "Goal0";
        }
        return "none";
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
