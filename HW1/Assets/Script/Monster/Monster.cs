using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    private SpriteRenderer sr;
    // Use this for initialization

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        //sr.color = new Color(Random.value, Random.value, Random.value, 1.0f);
        
    }

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }


   
}
