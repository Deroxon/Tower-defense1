using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBuildingArea : MonoBehaviour
{

    public Sprite newSprite;
    public Sprite originalSprite;

    private void Start()
    {
        originalSprite = GetComponent<Image>().sprite;
    }

    // Start is called before the first frame update
    private void OnMouseEnter() 
    {
        GetComponent<Image> ().sprite = newSprite;
    }

    // Update is called once per frame
    private void OnMouseExit() 
    {
        GetComponent<Image>().sprite = originalSprite;
    }
}
