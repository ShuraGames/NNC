using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSecretSpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    void Start()
    {
        var randomSpawn = Random.Range(0, 2);

        Debug.Log("Random = " + randomSpawn);

        if(randomSpawn == 1)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
