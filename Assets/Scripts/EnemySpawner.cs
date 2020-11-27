using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private GameObject enemyClone;
    public float spawnInc = -0.1f;
    private float repeatRate = 6f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        IncreaseDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(30, 30), 0, Random.Range(-30, 30));
        enemyClone = Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
        Vector3 spawnPos2 = new Vector3(Random.Range(-30, 30), 0, Random.Range(30, 30));
        enemyClone = Instantiate(Enemy, spawnPos2, Enemy.transform.rotation);
        Vector3 spawnPos3 = new Vector3(Random.Range(-30, -30), 0, Random.Range(-30, 30));
        enemyClone = Instantiate(Enemy, spawnPos3, Enemy.transform.rotation);
        Vector3 spawnPos4 = new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, -30));
        enemyClone = Instantiate(Enemy, spawnPos4, Enemy.transform.rotation);
        Invoke("SpawnEnemy", repeatRate);
       
    }
    void IncreaseDifficulty()
    {
        if (repeatRate + spawnInc > 1)
        {
            repeatRate += spawnInc;
        }
        Invoke("IncreaseDifficulty", repeatRate);

    }
}