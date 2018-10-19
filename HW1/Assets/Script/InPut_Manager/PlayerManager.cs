using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    private InPutState inputState;
    private Walk walkBehavior;
    private Animator animator;

    private void Awake(){
        inputState = GetComponent<InPutState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if( inputState.absVelX == 0) {
            ChangeAnimationState(0);
        }

        if (inputState.absVelX > 0)
        {
            ChangeAnimationState(0);
        }

    }


    void ChangeAnimationState(int value) {
        animator.SetInteger("AnimState", value);
    }
}
