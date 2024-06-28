using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public float repeatTime;
    public TextMeshProUGUI repeatText;
    // public Slider slider;

    List<Vector3> StartPoints = new List<Vector3>();
  
    // Start is called before the first frame update
    void Start()
    {
        repeatTime = 0.7f;
        StartPoints.Add(new Vector3(-5.5f, 0.5f, -2f));
        StartPoints.Add(new Vector3(6.3f, 0.5f, -5f));
        StartPoints.Add(new Vector3(14f, 0.5f, 3.5f));
        InvokeRepeating("CreateObj", 1.0f, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        // repeatTime = slider.value;
        repeatText.text = repeatTime.ToString();
    }

    void CreateObj()
    {
        int random_num = Random.Range(0, 3);
        Instantiate(PlayerPrefab, StartPoints[random_num], Quaternion.identity);
    }
    public void repeatUP()
    {
        CancelInvoke("CreateObj");
        if(repeatTime>0.1f)
        {
            repeatTime -= 0.05f;
        }
        InvokeRepeating("CreateObj", 0f, repeatTime);
    }
    public void repeatDown()
    {
        CancelInvoke("CreateObj");
        repeatTime += 0.05f;
        InvokeRepeating("CreateObj", 0f, repeatTime);
    }
}
