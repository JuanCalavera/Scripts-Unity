using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFoward : MonoBehaviour {

    [SerializeField]
    private Transform _background;
    private bool _stop = true;


    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.up * -1f * Time.deltaTime);

        if(transform.position.y <= 2.6f)
        {
            while(_stop == true)
            {
                Instantiate(_background, new Vector3(2.48910f, 47.9f, -0.1132f), Quaternion.identity);
                _stop = false;
            }
        }

        if(transform.position.y <= -12.8f)
        {
            Destroy(this.gameObject);
        }

    }


}
