using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOne : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    private GameObject activeBall;

    void Start()
    {
        activeBall = ball1 != null ? ball1 : ball2;
        ball1.GetComponent<BallMovement>().enabled = true;
        ball2.GetComponent<BallMovement>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            SwitchActiveBall();
        }
    }

    void SwitchActiveBall()
    {
        Vector3 tempPosition = ball1.transform.position;

        ball1.transform.position = ball2.transform.position;
        ball2.transform.position = tempPosition;

        if (activeBall == ball1)
        {
            ball1.GetComponent<BallMovement>().enabled = false;
            ball2.GetComponent<BallMovement>().enabled = true;
            activeBall = ball2;
        }
        else
        {
            ball1.GetComponent<BallMovement>().enabled = true;
            ball2.GetComponent<BallMovement>().enabled = false;
            activeBall = ball1;
        }
    }
}
