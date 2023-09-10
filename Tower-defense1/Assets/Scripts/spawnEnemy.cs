using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 4;
    public int spawnCount = 5;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            if(spawnCount > 0)
            {
                spawnEnemys();
                timer = 0;
                spawnCount--;
            }
            
        }
    }

    void spawnEnemys()
    {
        Instantiate(enemy);

    }
}
