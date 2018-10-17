using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : AbstractBehavior {

    public Sprite face_up;
    public Sprite face_down;
    public Sprite face_right;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var right = inputState.GetButtonValue(inputButtons[0]);
        var left  = inputState.GetButtonValue(inputButtons[1]);
        var up    = inputState.GetButtonValue(inputButtons[2]);
        var down  = inputState.GetButtonValue(inputButtons[3]);


        if (right){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = face_right;
            inputState.direction = Directions.Right;
            Debug.Log("Direction is @@@" + inputState.direction);
        }
        else if (left){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = face_right;
            inputState.direction = Directions.Left;
            Debug.Log("Direction is @@@" + inputState.direction);
        }
       

        transform.localScale = new Vector3((float)inputState.direction/2, (float)0.5, 1);


        if (up) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = face_up;
            //inputState.direction = Directions.Left;
            //transform.localScale = new Vector3((float)inputState.direction/2, (float)0.7, 1);
        }

        else if (down){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = face_down;
            //inputState.direction = Directions.Left;
            //transform.localScale = new Vector3((float)inputState.direction/2, (float)0.7, 1);
        }


    }


}
