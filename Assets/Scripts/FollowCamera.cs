using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // This things position (camera) should be the same as the bee's position
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3Int(0,0,-10);
    }
}
