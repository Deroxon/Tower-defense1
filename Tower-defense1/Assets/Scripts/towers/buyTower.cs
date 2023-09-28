using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyTower : MonoBehaviour
{

    public GameObject buildPlace;
    public GameObject optionBuyTree;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnMouseDown()
    {
        buildPlace.GetComponent<buildTower>().createTower("treeTower");


        //Debug.Log("kup drewno");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
