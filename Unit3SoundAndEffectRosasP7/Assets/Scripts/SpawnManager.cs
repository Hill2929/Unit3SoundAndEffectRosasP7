using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, -3);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        int Index = Random.Range(0, obstaclePrefab.Length);
        if (playerControllerScript.gameOver == false) if (playerControllerScript.gameOver == false)
            {
                Instantiate(obstaclePrefab[Index], spawnPos, obstaclePrefab[Index].transform.rotation);
            }
    }
}

