using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_TileMap : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
    

    }



}
