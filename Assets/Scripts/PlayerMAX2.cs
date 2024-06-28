using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using TMPro;

public class PlayerMAX2 : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    public GameObject GoalObj;
    GameObject[] targets;
    [SerializeField] private TextMeshPro target_num;
    public int goal_number;
    [SerializeField] private GameObject hitoObj;
    public bool isParty = false;
    public GameObject PartyObject;
    public bool PartyRange = false;



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
        this.gameObject.name = goal_number.ToString();
        if (GoalObj != null)
        {
            Player_Nav.SetDestination(GoalObj.transform.position);
        }
        else
        {
            goal_number = Random.Range(0, 4);
            GoalObj = GameObject.Find("Goal" + goal_number);
        }
    
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Goal")
        {
            if(isParty)
            {
                PlayerMAX2 playermax2 = PartyObject.GetComponent<PlayerMAX2>();
                playermax2.GoalObj = col.gameObject;
                // playermax2.Player_Nav.SetDestination(GoalObj.transform.position);
                playermax2.Player_Nav.destination = col.transform.position;
            }
            Debug.Log(isParty);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Hanni")
        {
            PartyRange = true;
        }
    }

}
