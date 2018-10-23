using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour{
    public float lifeTime = 15f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  
        if (lifeTime >0) {
           lifeTime -= Time.deltaTime;
            if (lifeTime <= 0 || this.gameObject.name == "Monster(clone)") {
                destruction();
            }
        }

    }


    void destruction() {
        Destroy(this.gameObject);

    }

}
