using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject Enemy;
    public MonsterClass EnemyStats;
    private SpriteRenderer spriteRenderer;
    

    public List<MonsterClass> MobsList = new List<MonsterClass>();

    void createEnemy() 
    {
         
    }
    // Start is called before the first frame update
    void Start()
    {
        // getting list of enemies
        // TextAsset EnemyList = Resources.Load<TextAsset>("enemyList");

        // using function in LevelsLogic to readJson
        // string data =  GetComponent<LevelsLogic>().readJson(EnemyList);

        // getting spriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();

        // getting sprite from sprite Renderer
        Sprite sprite = spriteRenderer.sprite;

        // getting string
        string sprit = sprite.name.ToLower();

        Debug.Log(sprit);

        MobsList = GetComponent<LevelsLogic>().InitialMonsters();

        Debug.Log(MobsList[0].Name);

        // finding monster
        MonsterClass EnemyStats = MobsList.Find(monster => sprit.Contains(monster.Name));


        Debug.Log(EnemyStats.Name);


        // setting move speed of Enemy
        GetComponent<zombieMove>().setMoveSpeed(EnemyStats.moveSpeed);

        Debug.Log(EnemyStats.currentHealthPoints);
    }






}
