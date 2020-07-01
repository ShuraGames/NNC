using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheck : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            PlayerSataticSet.loseGame = true;
        }
    }
}
