using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

    private float _moveSpeed;
    Rigidbody rigd;

	// Use this for initialization
	void Start () {
        _moveSpeed = 5;
        rigd = GetComponent<Rigidbody>();
}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0);
        rigd.velocity = movement * _moveSpeed;
    }
}
