using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalls", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBalls()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-6, 6), 6, Random.Range(-6, 6));
        int index = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }
}
