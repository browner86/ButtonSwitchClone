using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerController : MonoBehaviour
{
    public float turnSpeed = 50f;
    public bool isSpinning;
    public bool isClockwise;


    void Update()
    {
        if (isSpinning) transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
    public void changeSpinDirection()
    {
        turnSpeed = turnSpeed * -1;
    }

    public void TurnSpinOnOrOff()
    {
        isSpinning = !isSpinning;
    }

}
