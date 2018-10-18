using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    private InPutState inputState;
    private Walk walkBehavior;

    private void Awake(){
        inputState = GetComponent<InPutState>();
        walkBehavior = GetComponent<Walk>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
