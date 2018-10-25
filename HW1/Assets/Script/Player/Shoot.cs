using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject shot;
    private Transform playerPos;


    // Use this for initialization
    void Start()
    {
        //shot = GameObject.FindGameObjectWithTag("Player");
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
        //    Instantiate(shot, playerPos.position, Quaternion.identity);
        //}
    }
}
