using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    [SerializeField]private GameObject _tar;
    [SerializeField]private GameObject _player;
    [SerializeField]private int _followDistance;

   // put this script on your camera and assign _tar
    void Update ()
    {
        
        FollowTar();
        transform.LookAt(_player.transform);
    }
	

    void FollowTar()
    {
        var TarPos = _tar.transform.position;
        TarPos = new Vector3(TarPos.x, TarPos.y, TarPos.z + _followDistance);
        transform.position = Vector3.Lerp(transform.position, TarPos, Time.deltaTime);
    }
}
