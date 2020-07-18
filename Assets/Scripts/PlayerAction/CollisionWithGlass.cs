using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithGlass : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 3f);
        for (var i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].CompareTag("Glass"))
            {
                Rigidbody rbColliders = colliders[i].GetComponent<Rigidbody>();

                if (rbColliders != null)
                {
                    rbColliders.AddExplosionForce(4f, transform.position, 5f);
                    colliders[i].GetComponent<Collider>().enabled = false;
                    rbColliders.useGravity = true;
                }
            }
        }          
    }
}
