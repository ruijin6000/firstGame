using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
     public new string name = "name";
	 private Rigidbody2D body2d;
    //public float speed = 1f;
    // Use this for initialization
    public Text bar_num;
    private int energyBar_number_collected = 8 ;




    void Start () {
		body2d = GetComponent<Rigidbody2D> ();

    }
	

	// Update is called once per frame
	void Update () {
        //var lr = Input.GetAxis("Horizontal");
        // var ud = Input.GetAxis("Vertical");
        //body2d.velocity = new Vector2(speed*lr,speed*ud);
       //bar_num.text = "Energy Bar Number :" + energyBar_number_collected;

        Debug.Log("bar number is " + energyBar_number_collected);

        if (energyBar_number_collected==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "monster")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        if (col.gameObject.tag == "energy")
        {
           energyBar_number_collected--;


        }




    }
}
