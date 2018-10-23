using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform spawnPos;
    public GameObject spawnee;
    public float time = 0f; 

	// Use this for initialization
	void Start () {
        
     }
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time > 10f)
        {
            //Random.Range(1f, 5f);
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            time = 0;
            Debug.Log("time " + time);
        }
    }
}
