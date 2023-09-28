using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBuildingArea : MonoBehaviour
{

    public Sprite newSprite;
    public Sprite originalSprite;
    public SpriteRenderer spriteRenderer;
    private string spriteString;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteString = spriteRenderer.sprite.ToString();

        Debug.Log(spriteString);
    
    }

    // Start is called before the first frame update
    private void OnMouseEnter() 
    {
        spriteString = spriteRenderer.sprite.ToString();

        if (!spriteString.Contains("building sign") )
        {

        } else
        {
            spriteRenderer.sprite = newSprite;
        }

       
        
    }

    //need to be fixed, create another box which could be the realistic field to mouse over it
    private void OnMouseExit() 
    {
        /* need to be fixed, waiting for properly field in unity
        if (!spriteString.Contains("building sign"))
        {

        }
        else
        {
            spriteRenderer.sprite = originalSprite;
        }

        GetComponent<buildTower>().closeTowerMenu();

        */
    }


}
