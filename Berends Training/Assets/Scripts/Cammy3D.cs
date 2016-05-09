using UnityEngine;
using System.Collections;

public class Cammy3D : OmnipotentCamera
{

    //private const float Y_ANGLE_MIN = 0;
    //private const float Y_ANGLE_MAX = 50;

    //[SerializeField]
    //private float distance = 10;

    //Vector2 current = Vector2.zero;

    //OmnipotentCamera omniCam;

    //// Use this for initialization
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    current.x += Input.GetAxis("Horizontal2");
    //    current.y += Input.GetAxis("Vertical2");
    //}

    //void LateUpdate()
    //{
    //    Vector3 dir = new Vector3(0, 0, -distance);
    //    Quaternion rotation = Quaternion.Euler(current.x, current.y, 0);
    //    omniCam.camTransform.position = omniCam.target.position + rotation * dir;
    //    omniCam.camTransform.LookAt(omniCam.target.position);
    //}
}
