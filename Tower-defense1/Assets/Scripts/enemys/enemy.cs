﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using System.Text.Json;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject Enemy;
    public Monster EnemyStats;
    string EnemyList;
    public GameObject tak;

    void createEnemy() 
    {
         
    }
    // Start is called before the first frame update
    void Start()
    {
        // getting list of enemies
        TextAsset EnemyList = Resources.Load<TextAsset>("enemyList");

        // using function in LevelsLogic to readJson
        string data =  GetComponent<LevelsLogic>().readJson(EnemyList);

        Debug.Log("halo " + data);

        // to nie działa, do poprawy!! musisz deserializować dane na podstawie prawdopodobnie klasy monster, póki co mamy stworzony interface
        // Monster monstersData = JsonSerializer.Deserialize<MonsterClass>(data);

        // Debug.Log(monstersData);

    }



 
}
