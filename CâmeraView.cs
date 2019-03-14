using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CâmeraView : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float _speedSwipe = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    Gyroscope m_Gyro;

    private Touch initTouch = new Touch();


    private float speed = 10f;
    private float dir = -1;


    // Use this for initialization
    void Start()
    {
        if (Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }
#if UNITY_ANDROID || UNITY_IOS
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;

#endif
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
#if UNITY_STANDALONE
        if (Input.GetMouseButton(0))
        {

            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
#endif



#if UNITY_ANDROID || UNITY_IOS

        if (SystemInfo.supportsGyroscope)
        {
            Quaternion cameraRotation = new Quaternion(m_Gyro.attitude.x, m_Gyro.attitude.y, -m_Gyro.attitude.z, -m_Gyro.attitude.w);
            Mathf.Clamp(m_Gyro.attitude.y, -80f, 80f);
            this.transform.localRotation = cameraRotation;
        }
            foreach(Touch touch in Input.touches)
            {
                if(touch.phase == TouchPhase.Began)
                {
                    initTouch = touch;
                }

                if(touch.phase == TouchPhase.Moved)
                {
                pitch -= Input.GetTouch(0).deltaPosition.y * speed * Time.deltaTime;
                yaw += Input.GetTouch(0).deltaPosition.x * speed * Time.deltaTime;
                Mathf.Clamp(yaw, -80f, 80f);
                transform.eulerAngles = new Vector3(pitch, yaw, 0f);
                }
                if(touch.phase == TouchPhase.Ended)
                {
                    initTouch = new Touch();
                }
            }
        
#endif
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
