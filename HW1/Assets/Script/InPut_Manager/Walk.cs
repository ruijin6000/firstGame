using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior {
    public float speed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var up = inputState.GetButtonValue(inputButtons[2]);
        var down = inputState.GetButtonValue(inputButtons[3]);

        var velX = speed;
        var velY = speed;
        if (right || left) {
            velX *= left ? -1 : 1;
        }
        else{
            velX = 0;
        }


        if (up || down) {
            velY *= down ? -1 : 1;
        }
        else {
            velY = 0;
        }

        body2d.velocity = new Vector2(velX, velY);
    }

}
