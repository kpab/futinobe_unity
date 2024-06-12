using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject kyaku1Prefab; // 赤い客
    public GameObject kyaku2Prefab; // 青い客
    public GameObject kyaku1Prefab_Med; // 赤い客Medium Quality
    public GameObject kyaku1Prefab_None; // 赤い客None Quality
    public TextMeshProUGUI k1text; // 赤客テキスト
    public TextMeshProUGUI k2text; // 青..
    // エージェント数のカウント
    public static int k1count = 0;
    public static int k2count = 0;
    List<Vector3> k1Points = new List<Vector3>();
    List<Vector3> k2Points = new List<Vector3>();
    
    void Start()
    {
        k1Points.Add(new Vector3(-6f, 0.5f, -14f));
        k1Points.Add(new Vector3(-5.5f, 0.5f, -12f));
        k1Points.Add(new Vector3(-7.5f, 0.5f, -9f));

        k2Points.Add(new Vector3(5.5f, 0.5f, 12f));
        k2Points.Add(new Vector3(8f, 0.5f, 10f));
        k2Points.Add(new Vector3(6f, 0.5f, 10f));

        InvokeRepeating("CreateObj", 1.0f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        k1text.text = "red: " + k1count;
        k2text.text = "blue: " + k2count;
    }
    public void Retry()
    {
        SceneManager.LoadScene("Main");
        k1count = 0;
        k2count = 0;
    }
    void CreateObj()
    {
        int random_num = Random.Range(0, 3);
        Instantiate(kyaku1Prefab, k1Points[random_num], Quaternion.identity);
        random_num = Random.Range(0, 3);
        Instantiate(kyaku2Prefab, k2Points[random_num], Quaternion.identity);
    }
    public void changeMed()
    {
        kyaku1Prefab = kyaku1Prefab_Med;
    }
    public void changeNone()
    {
        kyaku1Prefab = kyaku1Prefab_None;
    }
}
