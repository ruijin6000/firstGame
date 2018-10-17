﻿using UnityEngine;
using System.Collections;
public abstract class AbstractBehavior : MonoBehaviour{

    public Buttons[] inputButtons;

    protected InPutState inputState;
    protected Rigidbody2D body2d;

    protected virtual void Awake(){
        inputState = GetComponent<InPutState>();
        body2d = GetComponent<Rigidbody2D>();

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
