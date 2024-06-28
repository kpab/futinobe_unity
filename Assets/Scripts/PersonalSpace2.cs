using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalSpace2 : MonoBehaviour
{
    private PlayerMAX2 playermax2;
    [SerializeField]private GameObject hontai;
    // Start is called before the first frame update
    void Start()
    {
        playermax2 = hontai.GetComponent<PlayerMAX2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="hito" && playermax2.PartyRange)
        {
            playermax2.GoalObj = col.gameObject;
            playermax2.PartyObject = hontai.gameObject;
            playermax2.isParty = true;
            Destroy(this.gameObject);
        }
        
        if(col.gameObject.tag=="Goal")
        {
            Destroy(hontai);
        }
    }


}
