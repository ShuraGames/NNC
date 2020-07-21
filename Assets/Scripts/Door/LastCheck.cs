using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheck : MonoBehaviour
{
    [SerializeField] private GameObject nextLvlLoadButton;


    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            PlayerSataticSet.loseGame = true;
            nextLvlLoadButton.SetActive(true);
        }
    }
}
