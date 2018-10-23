using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject.name);
        if (col.gameObject.name == "MyCharacter")
        {
            Destroy(gameObject);

        }

        if ( col.gameObject.tag == "monster")
        {

            Physics2D.IgnoreCollision( GetComponent<Collider2D>(), col.gameObject.GetComponent<Collider2D>());
        }


    }
}
