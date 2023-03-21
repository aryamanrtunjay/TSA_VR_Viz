using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    float seconds = 0.0f;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 10)
        {
            speed += 0.5f * Time.deltaTime;
        }
        seconds += Time.deltaTime;
        float step = speed * Time.deltaTime;
        if(seconds < 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-112.67f, 13.178f, -125.71f), step * speed);
            rotateToY(1.2f, -72.22f);
        }
        else if (seconds < 6)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-130.03f, 13.178f, -114.63f), step * speed);
            rotateToY(1.2f, -53.196f);
        }
    }

    void rotateToX(float rotSpeed, float rotDir)
    {
        Quaternion rotation = Quaternion.Euler(rotDir, 0, 0);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotSpeed);
    }

    void rotateToY(float rotSpeed, float rotDir)
    {
        Quaternion rotation = Quaternion.Euler(0, rotDir, 0);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotSpeed);
    }

    void rotateToZ(float rotSpeed, float rotDir)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, rotDir);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotSpeed);
    }
}
