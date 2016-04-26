using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	[SerializeField] private GameObject _object;
	// Use this for initialization
	[SerializeField] private bool _followTarget = false;
	[SerializeField] private bool _rotateTarget = false;
	[SerializeField] private bool _SmoothMove = true;

	[SerializeField] private float _heightValue = 5f;
	[SerializeField] private float _backValue = 5f;

	[SerializeField] private float _moveSpeed = 10f;
	private Vector3 newPos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (_followTarget) 
		{
			follow (_object);
		}
	}

	void follow(GameObject FollowObj)
	{
		newPos = new Vector3((FollowObj.transform.position.x),(FollowObj.transform.position.y + _heightValue), (FollowObj.transform.position.z + _backValue));

		if (_SmoothMove) {
			transform.position = Vector3.MoveTowards (transform.position, newPos, (_moveSpeed * Time.deltaTime));
		} else {
			transform.position = newPos;
		}
		if (_rotateTarget) 
		{
			if (Input.GetMouseButton (0)) 
			{
				transform.LookAt (FollowObj.transform);
				transform.RotateAround(FollowObj.transform.position, Vector3.up, Input.GetAxis("Mouse X") * _moveSpeed);
			}
		}
	}
	void moveToNew(GameObject newPos)
	{


	}
}
