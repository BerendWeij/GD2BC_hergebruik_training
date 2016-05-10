using UnityEngine;
using System.Collections;

public class TargetFollower : MonoBehaviour 
{
    [SerializeField]private Transform _target;
    [SerializeField]private Vector3 _offset;
    protected Vector3 _newPos;

    protected virtual void UpdatePosition()
    {
        _newPos = new Vector3(_target.position.x - _offset.x, _target.position.y - _offset.y, _target.position.z - _offset.z);
    }
	
	void Update () 
    {
        UpdatePosition();
        transform.position = _newPos;
	}
}
