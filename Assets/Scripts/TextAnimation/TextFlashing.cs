using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFlashing : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private bool isActiveFlashing = false;

    private void Start() {
        animator = GetComponent<Animator>();
        StartCoroutine(routine: AnimFlashingText());
    }

    private IEnumerator AnimFlashingText(){
        while (true)
        {           
            if(!isActiveFlashing){
                animator.SetBool("Flash", true);
                isActiveFlashing = true;
            }
            else 
            {
                animator.SetBool("Flash", false);
                isActiveFlashing = false;
            }
            yield return new WaitForSeconds(5);
        }
    }
}
