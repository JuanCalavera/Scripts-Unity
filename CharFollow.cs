using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFollow : MonoBehaviour {

    [SerializeField]
    private Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 NewPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, NewPos, SmoothFactor);
	}
}
