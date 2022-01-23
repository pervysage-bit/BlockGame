using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject enemyBlocks;
   
   
    
    //private float xSpawnRange = 3f;
    //private float zSpawnRange = 7f;
    private float startDelay = 2f;
    private float intervelDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyBlockSpawn", startDelay, intervelDelay);
    }

    // Update is called once per frame
    void Update()
    {
    

    }

    void EnemyBlockSpawn()
    {
        //Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnRange);
        int enemyIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if(enemyIndex != i)
            {
                Instantiate(enemyBlocks, spawnPoints[i].position, Quaternion.identity);
            }
        }
              
    }
}
