using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassAction : MonoBehaviour
{   
    public bool activeDamage = false;

    [SerializeField]private GameObject upCountTextPref;
    
    private Transform clickParent;

    private void Start() 
    {
        clickParent = GameObject.FindWithTag("Respawn").transform;
    }

    public void isDamage()
    {
            var ballCountMinus = Random.Range(2, 4);
            PlayerSataticSet.BallCount -= ballCountMinus;
            if(PlayerSataticSet.ScoreCountSet >= 0)
            {
                PlayerSataticSet.ScoreCountSet -= 5;
            }
            upCountTextPref.GetComponent<CountUp>().DonwCountText(ballCountMinus);
            var countInstantiate = Instantiate(upCountTextPref, clickParent);
            Destroy(countInstantiate, 1);
            PlayerSataticSet.hitCount = 0;
            activeDamage = true;
            PlayerSataticSet.playerSpeed = 5;
            PlayerAttack.ActiveOrb = 0;
            PlayerAttack.TwoCount = false;
            PlayerAttack.ThreeCount = false;
            PlayerSataticSet.hitCount = 0;
    }
}
