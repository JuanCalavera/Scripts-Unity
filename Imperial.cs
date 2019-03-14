using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imperial : MonoBehaviour {

    public int day, coin, count, numCamp;

    [SerializeField]
    private GameObject camp, troops;
    // Use this for initialization
    void Start () {

        day = 1;
        coin = 100;
        count = 1;
    }
    
    // Update is called once per frame
    void Update () {

   
            if (day == 1)
            {
            while (count == 1)
            {
                Instantiate(camp, new Vector3(13.58525f, 5.444833f, 10.37975f), Quaternion.identity);
                numCamp = 1;
                count++;
            }
            }
        


    }
}
