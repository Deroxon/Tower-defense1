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
        /* this part of code doesnt work beacuse we cannot import any package, beacuse in compiler they are automatically deleted so for now, code will be commented
         and maybe use in the future
          */
        // getting list of enemies
        TextAsset EnemyList = Resources.Load<TextAsset>("enemyList");

        // using function in LevelsLogic to readJson
        string data =  GetComponent<LevelsLogic>().readJson(EnemyList);

        Debug.Log("halo " + data);

        // to correct
        Monster monsterData = JsonUtility.FromJson<MonsterClass>(data);

         Debug.Log(monsterData);
       



    }



 
}
