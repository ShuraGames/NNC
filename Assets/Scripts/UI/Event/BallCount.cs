using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallCount : MonoBehaviour
{
    
    [SerializeField]private TextMeshProUGUI countBall;
    [SerializeField]private GlobalSetting  gS;
    [SerializeField]private PlayerAttack playerAttack;

    void Start()
    {
        countBall.text = gS.StartBallCount.ToString();
        playerAttack.minusBall += OnBallCountChanged;
    }

    void OnBallCountChanged(int changeBall)
    {
        countBall.text = changeBall.ToString();
    }

    private void OnTriggerEnter(Collider other) 
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 3f);

        if(colliders.Length > 3)
        {
            if(colliders[3].CompareTag("Glass"))
            {
                if(colliders[3].GetComponent<GlassAction>() != null)
                {
                    if(!colliders[3].GetComponent<GlassAction>().activeDamage)
                    {
                        colliders[3].GetComponent<GlassAction>().isDamage();
                    }       
                }
            }
        }
    }   
}
