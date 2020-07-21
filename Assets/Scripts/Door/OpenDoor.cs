using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private GameObject Player;
    [SerializeField]private float dist;
    [SerializeField]private string nameAnimation;
    [SerializeField]private float distanceToPlayer = 30;
    [SerializeField] private GameObject table;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        dist = Vector3.Distance(transform.position, Player.transform.position);
        if(dist <= distanceToPlayer){
            animator.SetBool(nameAnimation, true);
            if(table != null) 
                table.SetActive(false);
        }
    }
}
