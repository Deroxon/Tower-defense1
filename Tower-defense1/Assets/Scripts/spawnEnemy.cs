using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{

    public GameObject enemy;
    public int enemyCount = 5;
    public float timer = 0;
    public int spawnRate = 3;

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else if (timer >= spawnRate && enemyCount > 0)
            {
                spawnEnemys();
                timer = 0;
                enemyCount--;
            }


    }

    void spawnEnemys()
    {

        Instantiate(enemy);
    }
}
