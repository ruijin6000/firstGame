using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "monster") {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

    // Update is called once per frame
    void Update () {
       

    }
}
