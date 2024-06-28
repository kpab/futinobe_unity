using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject prefabEX;
    private bool canInstantiate = true;
    public float instantiateInterval = 1.0f; 
    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     transform.position += new Vector3(0, 0, 0.1f);
        // }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 0.1f;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * 0.1f * -1;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.A)&&canInstantiate)
        {
            Instantiate(prefabEX, this.transform.position, prefabEX.transform.rotation);
            canInstantiate = false;
            Invoke("ResetInstantiateFlag", instantiateInterval);
        }
    }

    void ResetInstantiateFlag()
    {
        canInstantiate = true;
    }
}
