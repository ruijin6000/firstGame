﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonState
{
    public bool value;
    public float holdTime = 0;

}

public enum Directions {
    Right = 1,
    Left = -1,
    Up = 1,
    Down = -1,

}
public class InPutState : MonoBehaviour
{
    public Directions direction = Directions.Right;
    private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();
    public float absVelX = 0f;
    public float absVelY = 0f;

    private Rigidbody2D body2d;


    void Awake(){
        body2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        absVelX = Mathf.Abs(body2d.velocity.x);
        absVelY = Mathf.Abs(body2d.velocity.y);
    }


    public void SetButtonValue(Buttons key, bool value)
    {
        if (!buttonStates.ContainsKey(key))
            buttonStates.Add(key, new ButtonState());

        var state = buttonStates[key];

        if (state.value && !value)
        {
            //dDebug.Log("Button" + key + " released" + state.holdTime);
            state.holdTime = 0;
        }
        else if (state.value && value)
        {

            state.holdTime += Time.deltaTime;

           //dDebug.Log("Button" + key + "down" + state.holdTime);
        }
        state.value = value;

    }

    public bool GetButtonValue(Buttons key) {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].value;
        else
            return false;
    }
}
