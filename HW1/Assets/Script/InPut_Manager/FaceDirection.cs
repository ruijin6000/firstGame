using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : AbstractBehavior {

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
            inputState.direction = Directions.Right;
            Debug.Log("Direction is @@@" + inputState.direction);
        }
        else if (left){
          
            inputState.direction = Directions.Left;
            Debug.Log("Direction is @@@" + inputState.direction);
        }
        //else if (up)  {
        //    inputState.direction = Directions.Up;
        //}
        //else if (down){
        //    inputState.direction = Directions.Down;
        //}


        transform.localScale = new Vector3((float)inputState.direction/2, (float)0.5, 1);
    }


}
