using UnityEngine;
using System.Collections;

public class RandomPositioner : MonoBehaviour 
{

    public void RandomPosition()
    {
        Vector3 randomPos = new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
        transform.position = randomPos;
    }
}
