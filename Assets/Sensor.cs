using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public CameraControl Camera;
    public float NewSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            Camera.NextBall();
            Camera.FollowSpeed = NewSpeed;
        }
    }
}
