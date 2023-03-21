using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] GameObject wheel;


    public float acceleration = 50f;
    public float brakingForce = 1000f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    float seconds = 0.0f;

    private void FixedUpdate()
    {
        seconds += Time.deltaTime;
        float currentAcceleration = 0;
        float rotation = 0;
        float currentBrakeForce = brakingForce;

        if (seconds < 3)
        {
            rotateWheel(1.2f, -20);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = -0.2f;
        }
        else if (seconds < 4.5)
        {
            rotateWheel(1.2f, 40);
            currentAcceleration = -acceleration;
            currentBrakeForce = 0;
            rotation = 0.4f;
        }
        else if (seconds < 6)
        {
            rotateWheel(1.2f, -30);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = -0.3f;
        }
        else if (seconds < 6.2)
        {
            rotateWheel(1.2f, 0);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = 0f;
        }
        else if (seconds < 9)
        {
            rotation = 0f;
        }
        else if (seconds < 12)
        {
            rotateWheel(1.2f, 260);
            currentAcceleration = acceleration/3;
            currentBrakeForce = 0;
            rotation = -0.84f;
        }
        else if(seconds < 14)
        {
            rotateWheel(1.2f, -40);
            rotation = -0.4f;
        }
        else if (seconds < 16)
        {
            rotateWheel(1.2f, 30);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = 0.3f;
        }
        else if (seconds < 21.24f)
        {
            rotateWheel(1.2f, 0);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = 0f;
        }
        else if (seconds < 30)
        {
            rotation = 0f;
        }
        else if(seconds < 33)
        {
            rotateWheel(1.2f, 170);
            currentAcceleration = acceleration;
            currentBrakeForce = 0;
            rotation = 1.23f;
        }
        else
        {
            rotateWheel(1.2f, 0);
        }

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBrakeForce;
        backRight.brakeTorque = currentBrakeForce;
        frontLeft.brakeTorque = currentBrakeForce;
        backLeft.brakeTorque = currentBrakeForce;


        currentTurnAngle = maxTurnAngle * rotation;

        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
    }

    void rotateWheel (float rotSpeed, float rotDir)
    {
        Quaternion rotation = Quaternion.Euler(0, rotDir, 0);

        wheel.transform.localRotation = Quaternion.Slerp(wheel.transform.localRotation, rotation, Time.deltaTime * rotSpeed);
    }

}

public static class ExtensionMethods
{
    public static float Map(float value, float leftMin, float leftMax, float rightMin, float rightMax)
    {
        return rightMin + (value - leftMin) * (rightMax - rightMin) / (leftMax - leftMin);
    }
}
