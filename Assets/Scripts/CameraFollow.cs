using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    [SerializeField]private Transform target;

    [SerializeField]private bool smoothFollow;

    [Range(-10f, 10f)]
    [SerializeField]private float xOffset;
    [Range(-10f, 10f)]
    [SerializeField]private float yOffset;
    [Range(-10f, 10f)]
    [SerializeField]private float zOffset;

    private Vector3 targetVector;
    private float smoothSpeed = 2f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (smoothFollow)
        {
            SmoothFollow();
        }
        else
            HardFollow();
	}

    void HardFollow()
    {
        transform.position = new Vector3(target.position.x - xOffset, target.position.y - yOffset, target.position.z - zOffset);
    }

    void SmoothFollow()
    {
        targetVector = new Vector3(target.position.x - xOffset, target.position.y - yOffset, target.position.z - zOffset);
        transform.position = Vector3.Lerp(transform.position, targetVector, smoothSpeed * Time.deltaTime);
    }

}
