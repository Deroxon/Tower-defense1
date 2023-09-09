using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMove : MonoBehaviour
{
    public float moveSpeed = 15;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;

      
    }
}
