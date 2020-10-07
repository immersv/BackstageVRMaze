using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    float enemyTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer -= Time.deltaTime;
        if (enemyTimer <= 0)
        {
            SpawnEnemy();
            enemyTimer = 5f;
        }
    }
    void SpawnEnemy()
    {
        GameObject enemyObject = Instantiate(enemy);
        Enemy enemyPos = enemyObject.GetComponent<Enemy>();
        enemyPos.enemyDirection = (player.transform.position - enemyPos.transform.position).normalized;
    }
}
