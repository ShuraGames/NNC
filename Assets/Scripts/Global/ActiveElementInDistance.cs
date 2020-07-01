using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveElementInDistance : MonoBehaviour
{
    [SerializeField]private float distance;
    [SerializeField]private Transform player;
    [SerializeField]private GameObject roomIsActive;

    private void Update() {
        distance = Vector3.Distance(transform.position, player.position);
        if(distance <= 60f){
            roomIsActive.SetActive(true);
        }
    }
}
