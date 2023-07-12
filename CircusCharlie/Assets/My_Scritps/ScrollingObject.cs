using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        if (!GameManger.instance.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);    
        }
       
        
    }
}
