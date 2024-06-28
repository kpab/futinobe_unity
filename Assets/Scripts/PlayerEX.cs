using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using TMPro;

public class PlayerEX : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    GameObject GoalObj;
    GameObject[] targets;
    [SerializeField] private GameObject TextObj;
    [SerializeField] private TextMeshPro target_num;
    private int goal_number;

    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Goal");
        goal_number = Random.Range(0, 4);
        Debug.Log("GoalNumber: " + goal_number);
        Player_Nav = GetComponent<NavMeshAgent>();
        GoalObj = GameObject.Find("Goal" + goal_number);
        SetNewDestination();
        target_num = TextObj.GetComponent<TextMeshPro>();
        target_num.text = goal_number.ToString();
        
    }

    void Update()
    {
        
        // target_num.text = GoalObj.name[GoalObj.name.Length - 1];
        target_num.text = GoalObj.name[GoalObj.name.Length - 1].ToString();
        // If the current destination is reached, set a new one
        if (!Player_Nav.pathPending && Player_Nav.remainingDistance < 0.1f)
        {
            SetNewDestination();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Goal")
        {
            Destroy(this.gameObject);
            // Debug.Log("当たった");
        }
        if (col.gameObject.tag == "hito")
        {
            GoalObj = SearchNearGoal();
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        Player_Nav.SetDestination(GoalObj.transform.position);
    }

    GameObject SearchNearGoal()
    {
        GameObject closest = null;
        float minDistance = Mathf.Infinity;
        Vector3 position = transform.position;
        
        foreach (GameObject target in targets)
        {
            if (target != GoalObj) // Exclude the current goal
            {
                Vector3 diff = target.transform.position - position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < minDistance)
                {
                    closest = target;
                    minDistance = curDistance;
                }
            }
        }
        return closest;
    }
}
