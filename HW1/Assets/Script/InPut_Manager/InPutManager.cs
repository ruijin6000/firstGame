using UnityEngine;
using System.Collections;


public enum Buttons
{
    Right,
    Left,
    Up,
    Down,
    A,
    B

}

public enum Condition {
   GreaterThan,
    LessThan
}

[System.Serializable]
public class InputAxisState{
    public string axisName;
    public float offValue;
    public Buttons button;
    public Condition condtion;

    public bool value {
        get {
               var val = Input.GetAxis(axisName);
                switch (condtion) {
                case Condition.GreaterThan:
                    return val > offValue;
                case Condition.LessThan:
                    return val < offValue;
            }
            return false;
        }
    }
}

public class InPutManager : MonoBehaviour{

    public InputAxisState[] inputs;
    public InPutState inputState;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var input in inputs) {
            //Debug.Log("offvalue is " + Input.GetAxis("Horizontal"));
            inputState.SetButtonValue(input.button, input.value);
        }
    }
}
