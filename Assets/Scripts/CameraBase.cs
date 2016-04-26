using UnityEngine;
using System.Collections.Generic;

public class CameraBase : MonoBehaviour {

    private GameObject _target;

    //not in a vector 3 because you might want to adjust one axis
    private float x_Offset;
    private float y_Offset;
    private float z_Offset;

    //using LateUpdate because you want your target to move before following it
    void LateUpdate()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        transform.position = new Vector3(_target.transform.position.x + x_Offset,
                                         _target.transform.position.y + y_Offset,
                                         _target.transform.position.z + z_Offset);
    }

    public GameObject SetTarget
    {
        get { return _target; }

        set { _target = value; }
    }
}
