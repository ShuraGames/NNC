using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private Text scoreCount;
    [SerializeField] private Text maxScoreCount;
    [SerializeField] GlobalSetting globalSetting;
    
    void Update()
    {
        scoreCount.text = PlayerSataticSet.ScoreCountSet.ToString();
        maxScoreCount.text = globalSetting.maxScoreCountMainMenu.ToString();
    }
}
