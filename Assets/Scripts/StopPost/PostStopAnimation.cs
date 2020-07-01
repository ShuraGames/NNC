using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostStopAnimation : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private GameObject player;
    [SerializeField]private float maxDistance;
    [SerializeField]private string nameAnimaton;
    

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(DistanceToPlayer() < maxDistance){
            StartedAnimationClip(nameAnimaton);
        }
    }

    private  float DistanceToPlayer(){

        float distance = Vector3.Distance(transform.position, player.transform.position);

        return distance;
    }

    void StartedAnimationClip(string name){
        animator.SetBool(name, true);
    }
}
