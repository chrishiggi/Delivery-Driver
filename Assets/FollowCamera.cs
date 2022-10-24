using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        var height = new Vector3(0,0,-10);
        transform.position = thingToFollow.transform.position + height;
    }
}
