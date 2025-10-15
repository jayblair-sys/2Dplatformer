using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTimer;
    public float rateOfNewEnemies;
    public float leftXSpawn;
    public float rightXSpawn;

    public GameObject enemyPrefab;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= rateOfNewEnemies)
        {
            Vector3 spawnPosition = spawnPoint.position;
            spawnPosition.x += Random.Range(-2.5f, 2.5f);

            SpawnEnemy(spawnPosition);
            spawnTimer -= 1;

        }
    }

    public void SpawnEnemy(Vector3 newPosition)
    {
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint);
        newEnemy.transform.position = newPosition;
    }
}
