using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField]private Camera player;
    [SerializeField]private float checkSpeedBoost = 0.5f;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){            
            player.GetComponent<PlayerMove>().moveSpeed += checkSpeedBoost;
        }
    }
}
