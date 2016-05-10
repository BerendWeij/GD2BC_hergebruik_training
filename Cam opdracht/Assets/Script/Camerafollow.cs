using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Camerafollow : MonoBehaviour {

    [SerializeField]
    GameObject _followObject;

    [SerializeField]
    bool _followWithAnimation;
    [SerializeField]
    public Vector3 _offset;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = (_followObject.transform.position + _offset);
	}
}
