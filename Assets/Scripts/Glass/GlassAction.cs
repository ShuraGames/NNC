using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassAction : MonoBehaviour
{
    [SerializeField]private Transform clickParent;
    [SerializeField]private GameObject upCountTextPref;

    public bool activeDamage = false;

    private void Start() 
    {
        clickParent = GameObject.FindWithTag("Respawn").transform;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            
        }   
    }

    public void isDamage()
    {
            var ballCountMinus = Random.Range(2, 4);
            PlayerSataticSet.BallCount -= ballCountMinus;
            upCountTextPref.GetComponent<CountUp>().DonwCountText(ballCountMinus);
            var countInstantiate = Instantiate(upCountTextPref, clickParent);
            Destroy(countInstantiate, 1);
            PlayerSataticSet.hitCount = 0;
            activeDamage = true;
    }
}
