using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInTap : MonoBehaviour
{
    private void Start() 
    {
        Time.timeScale = 0;    
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))    
        {
            gameObject.SetActive(false);
            Time.timeScale = 1f;
            PlayerSataticSet.playerSpeed = 3;
        }
    }
}
