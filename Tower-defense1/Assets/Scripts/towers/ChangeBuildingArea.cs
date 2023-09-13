using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBuildingArea : MonoBehaviour
{

    public Sprite newSprite;
    public Sprite originalSprite;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    private void OnMouseEnter() 
    {
        spriteRenderer.sprite = newSprite;
        
    }

    // Update is called once per frame
    private void OnMouseExit() 
    {
        spriteRenderer.sprite = originalSprite;
    }
}
