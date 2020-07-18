using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if(PlayerSataticSet.BallCount == 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                PlayerSataticSet.loseGame = true;
            }
        }
    }
}
