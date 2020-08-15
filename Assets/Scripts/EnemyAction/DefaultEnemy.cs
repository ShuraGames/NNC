using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultEnemy : MonoBehaviour
{

    public int healthEnemy = 1;
    [SerializeField]private GameObject player;
    [SerializeField]private Transform clickParent;
    [SerializeField]private int ReversBall;
    [SerializeField]private GameObject UpCountTextPref;
    [SerializeField]private GameObject deathEffect;

    private CountUp UcTp;

    private void Start() 
    {
        UcTp = UpCountTextPref.GetComponent<CountUp>();
    }

    private void Update() 
    {
        DeathObj();
    }

    void DeathObj()
    {
        if(healthEnemy <= 0) 
        {
            PlayerSataticSet.hitCount += 1;
            PlayerSataticSet.BallCount += ReversBall;
            PlayerSataticSet.ScoreCountSet += 5;
            UcTp.UpCountText(ReversBall);
            var CountInts = Instantiate(UpCountTextPref, clickParent);
            Destroy(gameObject);
            var deathEff = Instantiate(deathEffect, transform.position, Quaternion.identity);
            ParticleSystem psDeath = deathEffect.GetComponent<ParticleSystem>();
            Destroy(deathEff, psDeath.main.duration);
            Destroy(CountInts, 1);
        }
    }

}
 