using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]private GameObject player;
    [SerializeField]private GameObject endGame;
    [SerializeField]private Slider progressSlider;
    [SerializeField]private float distance;
    

    private void Start() {
        distance = Vector3.Distance(player.transform.position, endGame.transform.position);
        progressSlider.maxValue = distance;
    }

    void Update()
    {
        GetProgressLvl();
    }

    void GetProgressLvl(){
        float activeDistance = Vector3.Distance(player.transform.position, endGame.transform.position);
        progressSlider.value = distance - activeDistance;
    }


}
