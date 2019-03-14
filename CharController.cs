using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private Vector3 _forward, right;
    [SerializeField]
    private Animator _anim;
    public bool _switchControl;
    private bool _start;
    private Transform person;
    [SerializeField]
    private Joystick _joystick;

    // Use this for initialization
    void Start () {
        _forward = Camera.main.transform.forward;
        _forward.y = 0;
        _forward = Vector3.Normalize(_forward);
        right = Quaternion.Euler(new Vector3(0, 90f, 0)) * _forward;
        _anim = GetComponent<Animator>();
        _switchControl = true;
        _start = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (_joystick.Horizontal >= .5f || _joystick.Vertical >= .5f || _joystick.Horizontal <= -0.5f || _joystick.Vertical <= -0.5f)
        {
            Move();
            if (_switchControl == true)
            {
                _anim.Play("Walking");
            }
        }
        else
        {
            _anim.Play("idle");
        }
	}

    void Move()
    {
        if (_switchControl == true)
        {
            Vector3 direction = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            Vector3 rightMovement = right * _moveSpeed * Time.deltaTime * _joystick.Horizontal;
            Vector3 upMovement = _forward * _moveSpeed * Time.deltaTime * _joystick.Vertical;

            Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

            transform.forward = heading;
            transform.position += rightMovement;
            transform.position += upMovement;
        }
    }

}
