using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTouch : MonoBehaviour {

    [SerializeField] private float _moveSpeed = 300f, _screenWidth;
    [SerializeField] private GameObject _character;
    private Rigidbody2D _rb;

	// Use this for initialization
	void Start () {
        _screenWidth = Screen.width;
        _rb = _character.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > _screenWidth / 2)
            {
                RunCharacter(1f);
            }

            if (Input.GetTouch(i).position.x < _screenWidth / 2)
            {
                RunCharacter(-1f);
            }

            ++i;
        }
    }

    private void FixedUpdate()
    {
#if UNITY_EDITOR

        RunCharacter(Input.GetAxis("Horizontal"));

#endif
    }

    private void RunCharacter(float _horizontalInput)  
    {
        _rb.AddForce(new Vector2(_horizontalInput * _moveSpeed * Time.deltaTime, 0));
    }
}
