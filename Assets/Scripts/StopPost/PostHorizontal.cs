using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostHorizontal : MonoBehaviour
{
     private Animator animator;
    [SerializeField]private GameObject player;
    [SerializeField]private float maxDistance;    

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(DistanceToPlayer() <= maxDistance){
            animator.SetBool("PHTrue", true);
        }
    }

    private  float DistanceToPlayer(){
        float distance = Vector3.Distance(transform.position, player.transform.position);
        return distance;
    }
}
