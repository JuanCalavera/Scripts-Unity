using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour {
    
    
    void Start()
    {
    }

    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Foward")
        {
        }
    }
}
