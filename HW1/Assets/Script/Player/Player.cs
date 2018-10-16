using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
     public new string name = "name";
	 private Rigidbody2D body2d;
	 public float speed = 1f;
	// Use this for initialization
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		var lr = Input.GetAxis("Horizontal");
        var ud = Input.GetAxis("Vertical");
       body2d.velocity = new Vector2(speed*lr,speed*ud);

    
	}
}
