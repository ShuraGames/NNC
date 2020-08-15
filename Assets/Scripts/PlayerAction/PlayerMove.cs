using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GlobalSetting globalSetting;

    private void Start() 
    {
        StartCoroutine(BoostSpeed());
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * PlayerSataticSet.playerSpeed * Time.deltaTime);

        if(PlayerSataticSet.BallCount <= 0)
        {
            if(Input.GetMouseButtonDown(0))
                PlayerSataticSet.loseGame = true;
        }
    }

    private IEnumerator BoostSpeed()
    {
        while(true)
        {
            PlayerSataticSet.playerSpeed += 0.5f;
            yield return new WaitForSeconds(10);
        }
    }
}
