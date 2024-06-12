using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public GameObject WallPrefab; // 壁
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 移動
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(PlayerSpeed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(PlayerSpeed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(0f, 0f, PlayerSpeed);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0f, 0f, PlayerSpeed);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(WallPrefab, transform.position, Quaternion.identity);
        }


    }


}
