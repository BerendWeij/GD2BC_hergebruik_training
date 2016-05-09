using UnityEngine;
using System.Collections;

public class OmnipotentCamera : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 10;
    private const float Y_ANGLE_MAX = 89;

    public Transform target;

    private Transform camTransform;

    // 2D Bools
    [SerializeField]
    bool _isCameraOffset2D = false;
    [SerializeField]
    bool _followTarget2D = false;

    // 3D Bools
    [SerializeField]
    bool _isOrbiting = false;
    [SerializeField]
    bool _followBehindTarget = false;
    [SerializeField]
    bool _freeCamera = false;

    [SerializeField]
    int _orbitingSpeed;

    [SerializeField]
    private float distance = 10;
    [SerializeField]
    float _distanceAway;
    [SerializeField]
    float _distanceUp;
    [SerializeField]
    float _dampTime = 0.15f;// the speed of returning to orignal position
    [SerializeField]
    float _smooth; 

    Vector3 cameraTargetPosition;

    Vector3 offset;

    Vector2 current = Vector2.zero;

    Vector3 velocity = Vector3.zero;
    Camera cam;

    void Start()
    {
        camTransform = transform;
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        //2D
        _isCameraOffset2D = Input.GetKey(KeyCode.JoystickButton4);
        _followTarget2D = Input.GetKey(KeyCode.Keypad4);
        //3D
        _isOrbiting = Input.GetKey(KeyCode.Keypad1);
        _followBehindTarget = Input.GetKey(KeyCode.Keypad2);
        _freeCamera = Input.GetKey(KeyCode.JoystickButton5);

        if (target && _freeCamera)
        {
            current.y += Input.GetAxis("Horizontal2");
            current.x += Input.GetAxis("Vertical2");

            current.x = Mathf.Clamp(current.x, Y_ANGLE_MIN, Y_ANGLE_MAX);
        } 
    }

    void LateUpdate()
    {
        // 2D Camera
        if (target && _followTarget2D)
        {
            Vector3 point = cam.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, _dampTime);
        }

        if (_isCameraOffset2D)
        {
            offset = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);

            gameObject.transform.Translate(offset);
        }

        // 3D Camera
        if (target && _isOrbiting)
        {
            transform.RotateAround(target.position, Vector3.up, _orbitingSpeed * Time.deltaTime);
            transform.LookAt(target);
        }

        if (target && _followBehindTarget)
        {
            cameraTargetPosition = target.position + target.up * _distanceUp - target.forward * _distanceAway;

            transform.position = Vector3.Lerp(transform.position, cameraTargetPosition, Time.deltaTime * _smooth);

            transform.LookAt(target);
        }

        if (target && _freeCamera)
        {
            Vector3 dir = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(current.x, current.y, 0);
            camTransform.position = target.position + rotation * dir;
            camTransform.LookAt(target.position);
        }
        
    }
}
