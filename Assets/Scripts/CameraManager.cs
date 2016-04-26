using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

    public GameObject cubie;
    private CameraBase _camera;

	// Use this for initialization
	void Start () {
        _camera.SetTarget = cubie;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
