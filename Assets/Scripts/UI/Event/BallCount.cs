using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallCount : MonoBehaviour
{
    
    [SerializeField]private TextMeshProUGUI countBall;
    [SerializeField]private GlobalSetting  gS;

    void Start()
    {
        countBall.text = gS.StartBallCount.ToString();
    }

    void Update()
    {
        countBall.text = PlayerSataticSet.BallCount.ToString();
    }
}
