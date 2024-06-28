using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainCamera;
    public GameObject subCamera;
    void Start()
    {
        subCamera.SetActive(false);
    }
 
    void Update()
    {
        // もしSpaceキーが押されたならば、
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 各カメラオブジェクトの有効フラグを逆転(true→false,false→true)させる
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
        }
    }
}
