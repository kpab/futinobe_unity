using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chk : MonoBehaviour
{
    public int chk_num;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="hito")
        {
            if(chk_num==0)
            {
                konzatu.chk0++;
                // Debug.Log("0に入った"+ konzatu.chk0);
            }
            else if(chk_num==1)
            {
                konzatu.chk1++;
            }
            else if(chk_num==2)
            {
                konzatu.chk2++;
            }
            else if(chk_num==3)
            {
                konzatu.chk3++;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag=="hito")
        {
            if(chk_num==0)
            {
                konzatu.chk0--;
            }
            else if(chk_num==1)
            {
                konzatu.chk1--;
            }
            else if(chk_num==2)
            {
                konzatu.chk2--;
            }
            else if(chk_num==3)
            {
                konzatu.chk3--;
            }
        }
    }
}
