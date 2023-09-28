using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buildTower : MonoBehaviour
{
    public GameObject buildPlace;
    public GameObject optionBuyTree;
    public GameObject optionBuyTree2;
    public bool isMenuOpen = false;
    public Sprite treeSprite;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // find a child component 'buyTreeTower'
        optionBuyTree = buildPlace.transform.Find("buyTreeTower").gameObject;
        optionBuyTree2 = buildPlace.transform.Find("buyTreeTower2").gameObject;
        spriteRenderer = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnMouseDown()
    {

        openTowerMenu();
    }


    public void openTowerMenu()
    {
       

        // checking if player clicked 
        if (Input.GetMouseButtonDown(0))
        {
   

            if(gameObject.CompareTag("buildField"))
            {
                optionBuyTree.SetActive(true);
                isMenuOpen = true;
               //Debug.Log("clicked");

                optionBuyTree2.SetActive(true);
                isMenuOpen = true;
                //Debug.Log("clicked");
            }

        }
    }

    public void createTower(string typeTower)
    {

        switch (typeTower)
        {
            case "treeTower":
                {
                    spriteRenderer.sprite = treeSprite;
                }
                break;
        }

        // changing tower to active to make the possible to attack
        buildPlace.tag = "activeTower";

        buildPlace.AddComponent<TowerLogic>();


       // adding prefab to this script
       // GetComponent<TowerLogic>().bulletPrefab = Resources.Load<GameObject>("Prefabs/stone");

      


    }

    public void closeTowerMenu()
    {
        if(isMenuOpen)
        {
            optionBuyTree.SetActive(false);
            optionBuyTree2.SetActive(false);
        }
        
    }
}
