using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{

    [SerializeField]private GameObject player;
    [SerializeField]private GlobalSetting globalSetting;

    private int hitCount;
    private bool TwoCount, ThreeCount;
     private void Start()
     {
         hitCount = player.GetComponent<PlayerAttack>().hitCount; 
     }

    void Update()
    {
        CheckPlayerCollider();
    }

    void CheckPlayerCollider()
    {

        RaycastHit hit;

        if(Physics.Raycast(transform.position + transform.up, transform.forward, out hit, 200f ) 
        || Physics.Raycast(transform.position, -transform.up, out hit, 200f ))
        {
            if(hit.collider.tag == "Check")
            {       
                isCheck(hit);
            }
        }
    }

    void isCheck(RaycastHit hit)
    {
        player = hit.collider.gameObject;
        PlayerAttack.ActiveOrb = globalSetting.ActiveOrb;
        hitCount = globalSetting.hitCount;
        PlayerAttack.TwoCount = false;
        PlayerAttack.ThreeCount = false;
        PlayerSataticSet.hitCount = 0;
    }
}
