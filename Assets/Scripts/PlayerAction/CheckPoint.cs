using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField]private Camera player;
    [SerializeField]private float checkSpeedBoost;


    private void Update() {

        Debug.Log(PlayerSataticSet.playerSpeed.ToString());
    }




    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player"){            
            PlayerSataticSet.playerSpeed += checkSpeedBoost;
        }
    }
}
