using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

    private float _moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
    }
}
