using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject.name);
        if (col.gameObject.name == "Monster_front" || col.gameObject.name =="Monster_front(Clone)") {
            Destroy(gameObject);

        }

         if (col.gameObject.name == "energy")
        {
            Destroy(col.gameObject);

        }

        //if (col.gameObject.name == "energy")
        //{
        //    Debug.Log("cooooooooo");
        //    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), col.gameObject.GetComponent<Collider2D>());
        //}
    }

    // Update is called once per frame
    void Update () {
       

    }
}
