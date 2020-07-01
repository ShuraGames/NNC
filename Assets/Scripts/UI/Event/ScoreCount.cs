using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    [SerializeField]private Text scoreCount;
    
    void Update()
    {
        scoreCount.text = PlayerSataticSet.ScoreCountSet.ToString();
    }
}
