using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDeath : MonoBehaviour
{

    public GameObject KillGlassOne;
    public int lifeGlass;

    private Animation anim;
    [SerializeField]private Transform clickParent;
    [SerializeField]private GameObject upCountTextPref;

    private void Start() {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        GlassDestruct();
    }

    void GlassDestruct(){
        if(lifeGlass <= 0){
            Destroy(gameObject);    
            Debug.Log("Lol");
            PlayerSataticSet.ScoreCountSet += 5;
            GameObject destruct = (GameObject)Instantiate(KillGlassOne);
            destruct.transform.position = transform.position;   
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            var ballCountMinus = Random.Range(2, 5);
            lifeGlass -= 2;
            GlassDestruct();
            PlayerSataticSet.BallCount -= ballCountMinus;
            upCountTextPref.GetComponent<CountUp>().DonwCountText(ballCountMinus);
            var CountInts = Instantiate(upCountTextPref, clickParent);
            Destroy(CountInts, 1);
            PlayerSataticSet.hitCount = 0;
        }
    }
}
