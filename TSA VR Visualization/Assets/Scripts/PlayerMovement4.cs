using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement4 : MonoBehaviour
{
    float seconds = 0.0f;
    float speed = 8;
    [SerializeField] GameObject car;
    [SerializeField] Animator dogAnimator;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if(seconds < 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(367.76f, 0.26f, 505.5f), speed * Time.deltaTime * 13);
            car.transform.position = Vector3.MoveTowards(car.transform.position, new Vector3(367.9f, 0.09f, 504.94f), speed * Time.deltaTime * 13);
        }
        else if (seconds < 6)
        {
            transform.position = new Vector3(367.76f, 0.9f, 508.9f);
            Quaternion rotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = rotation;
        }
        else if(seconds < 9)
        {
            rotateToY(1.2f, 67.597f);
        }
        else if(seconds < 13.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(413.55f, 0.9f, 530.06f), speed * Time.deltaTime * 1.4f);
        }
        else if (seconds < 15)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(417.71f, 0.9f, 536.49f), speed * Time.deltaTime);
            rotateToY(2f, 28.521f);
        }
        else if (seconds < 18)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(435.808f, 0.9f, 545.198f), speed * Time.deltaTime);
            rotateToY(2f, 64.285f);
        }
        else if (seconds < 28)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(433.32f, 0.9f, 551.1f), speed * Time.deltaTime);
            rotateToY(2f, 13.584f);
        }
        else if( seconds < 29)
        {
            rotateToY(2f, 125.338f);
        }
        else if (seconds < 31)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(436.97f, 0.9f, 547.71f), speed * Time.deltaTime);
            rotateToY(2f, 131.754f);
        }
        else if (seconds < 34f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(455.76f, 0.9f, 530.45f), speed * Time.deltaTime);
        }
        else if(seconds < 35)
        {
            rotateToY(2f, 186.697f);
        }
        else if(seconds < 38)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(452.79f, 0.9f, 509.27f), speed * Time.deltaTime);
        }
        else if(seconds < 40)
        {
            rotateToY(2f, 263.522f);
            
        }
        else if(seconds < 41)
        {
            dogAnimator.SetBool("Stand Up", true);
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
