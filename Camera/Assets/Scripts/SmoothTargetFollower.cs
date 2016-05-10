using UnityEngine;
using System.Collections;

public class SmoothTargetFollower : TargetFollower
{
    [Range(0, 10)]
    [SerializeField]private float _damping;

    protected override void UpdatePosition() 
    {
        base.UpdatePosition();
        _newPos = Vector3.Lerp(transform.position, _newPos, _damping * Time.deltaTime);
	}
}