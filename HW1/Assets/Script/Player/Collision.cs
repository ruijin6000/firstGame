using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "monster") {
            Destroy(gameObject);
        }


    }

    // Update is called once per frame
    void Update () {
       

    }
}
