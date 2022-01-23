using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTesting : MonoBehaviour
{

    public GameObject[] cube;
    public GameObject spawnCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int cubeIndex = Random.Range(0, cube.Length);
        for (int i = 0; i < cube.Length; i++)
        {
            if(cubeIndex != i)
            {
               // Instantiate(spawnCube, cube[i].position, Quaternion.identity);
            }
        }
    }
}
