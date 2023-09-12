using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildTower : MonoBehaviour
{
    public GameObject buildPlace;
    public GameObject optionBuyTree;
    public bool isMenuOpen = false;
    public Sprite treeSprite;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // find a child component 'buyTreeTower'
        optionBuyTree = buildPlace.transform.Find("buyTreeTower").gameObject;
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
            }

        }
    }

    public void createTower( string typeTower)
    {

        switch (typeTower)
        {
            case "treeTower": {
                    spriteRenderer.sprite = treeSprite;
            }
                break;
        }
       

    }

    public void closeTowerMenu()
    {
        if(isMenuOpen)
        {
            optionBuyTree.SetActive(false);
        }
        
    }
}
