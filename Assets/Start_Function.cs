using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Function : MonoBehaviour
{
    public GameObject Still_Kitten;
    public GameObject Animated_Kitten;
    public GameObject FirstBall;
    Rigidbody ballRB;
    public float AppliedForce = 1f;
    bool Started = false;

    void Start()
    {
        Still_Kitten.SetActive(true);
        Animated_Kitten.SetActive(false);
        ballRB = FirstBall.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Started == false && Input.GetKeyDown(KeyCode.Space))
        {
            StartMachine();
        }
    }

    void StartMachine()
    {
        Still_Kitten.SetActive(false);
        Animated_Kitten.SetActive(true);
        ApplyForce();
        Started = true;
    }

    void ApplyForce()
    {
        ballRB.AddForce(AppliedForce, 0, 0);
    }
}
