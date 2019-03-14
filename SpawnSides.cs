using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSides : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
        if(transform.position.x > 3.7f)
        {
            transform.position = new Vector2(-3.31f, transform.position.y);
        }
        if (transform.position.x < -3.31f)
        {
            transform.position = new Vector2(3.7f, transform.position.y);
        }
    }
}
