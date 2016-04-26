using UnityEngine;
using System.Collections;

public class OmnipotentCamera : MonoBehaviour
{

    [SerializeField]
    bool isCameraOffset = false;
    [SerializeField]
    bool followTarget = false;

    
    Vector3 offset;

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    Camera cam;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        if (target && followTarget)
        {
            Vector3 point = cam.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

        if (isCameraOffset)
        {
            offset = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);
            Debug.Log(offset);

            gameObject.transform.Translate(offset);
        }
    }
}
