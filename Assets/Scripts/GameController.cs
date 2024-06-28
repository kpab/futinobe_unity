using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject kyaku1Prefab_high; // 赤い客
    public GameObject kyaku1Prefab_Med; // 赤い客Medium Quality
    public GameObject kyaku1Prefab_None; // 赤い客None Quality
    public GameObject kyaku2Prefab_high; // 青↓
    public GameObject kyaku2Prefab_Med;
    public GameObject kyaku2Prefab_None;
    private GameObject usedKyaku1prefab;
    private GameObject usedKyaku2prefab;
    //----------------^_^---------------------
    public TextMeshProUGUI k1text; // 赤客テキスト
    public TextMeshProUGUI k2text; // 青..
    // エージェント数のカウント
    public static int k1count = 0;
    public static int k2count = 0;
    List<Vector3> k1Points = new List<Vector3>();
    List<Vector3> k2Points = new List<Vector3>();
    public float repeatTime;
    public Slider slider;
    
    void Start()
    {
        repeatTime = 0.7f;
        k1Points.Add(new Vector3(-6f, 0.5f, -14f));
        k1Points.Add(new Vector3(-5.5f, 0.5f, -12f));
        k1Points.Add(new Vector3(-7.5f, 0.5f, -9f));

        k2Points.Add(new Vector3(5.5f, 0.5f, 12f));
        k2Points.Add(new Vector3(8f, 0.5f, 10f));
        k2Points.Add(new Vector3(6f, 0.5f, 10f));

        usedKyaku1prefab = kyaku1Prefab_high;
        usedKyaku2prefab = kyaku2Prefab_high;

        InvokeRepeating("CreateObj", 1.0f, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        k1text.text = "red: " + k1count;
        k2text.text = "blue: " + k2count;
        repeatTime = slider.value;
    }
    
    void CreateObj()
    {
        int random_num = Random.Range(0, 3);
        Instantiate(usedKyaku1prefab, k1Points[random_num], Quaternion.identity);
        random_num = Random.Range(0, 3);
        Instantiate(usedKyaku2prefab, k2Points[random_num], Quaternion.identity);
    }
 

    // 以下ボタン
    public void GoMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void Retry()
    {
        SceneManager.LoadScene("futinobe03");
        k1count = 0;
        k2count = 0;
    }

    public void changeHigh1()
    {
        usedKyaku1prefab = kyaku1Prefab_high;
    }
    public void changeMed1()
    {
        usedKyaku1prefab = kyaku1Prefab_Med;
    }
    public void changeNone1()
    {
        usedKyaku1prefab = kyaku1Prefab_None;
    }

    public void changeHigh2()
    {
        usedKyaku2prefab = kyaku2Prefab_high;
    }
    public void changeMed2()
    {
        usedKyaku2prefab = kyaku2Prefab_Med;
    }
    public void changeNone2()
    {
        usedKyaku2prefab = kyaku2Prefab_None;
    }
}
