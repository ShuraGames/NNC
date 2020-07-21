using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostMove : MonoBehaviour
{
    [SerializeField] private GameObject onePoint;
    [SerializeField] private GameObject twoPoint;
    [SerializeField] private float speedMove = 5f;

    private bool isActiveMoveRight = false;

    private void Update() 
    {
        if(!isActiveMoveRight)
            transform.Translate(-Vector3.right * speedMove * Time.deltaTime);
        else
            transform.Translate(Vector3.right * speedMove * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.name);
        if(other.name == onePoint.name)
            isActiveMoveRight = false;
        else if(other.name == twoPoint.name)
            isActiveMoveRight = true;
    }

}
