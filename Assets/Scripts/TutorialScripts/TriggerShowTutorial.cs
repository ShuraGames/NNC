using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShowTutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorialObj;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            tutorialObj.SetActive(true);
        }
    }
}
