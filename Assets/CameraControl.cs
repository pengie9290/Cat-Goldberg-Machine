using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public List<GameObject> Balls;
    public float FollowSpeed = 1f;
    public int CurrentObjectIndex = 0;
    float zPos = -10;

    void Start()
    {
        zPos = transform.position.z;
    }

    public void NextBall()
    {
        if (CurrentObjectIndex < Balls.Count - 1) CurrentObjectIndex += 1;
    }
    
    void Update()
    {
        MoveTowards();
    }

    void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, Balls[CurrentObjectIndex].transform.position, FollowSpeed * Time.deltaTime);
        transform.position = new Vector3 (transform.position.x, transform.position.y, zPos);
    }
}
