using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource audioSource;
    private bool playAudio1 = true;
    private bool playAudio2 = true;
    private bool playAudio3 = true;
    private bool playAudio4 = true;
    public AudioClip house1;
    public AudioClip house2;
    public AudioClip house3;
    public AudioClip house4;
    float seconds = 34.0f;
    float speed = 2;
    [SerializeField] GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    // Starting coordinate (603, 2.25, 603)
    void Update()
    {
        seconds += Time.deltaTime;
        float step = speed * Time.deltaTime;
        if (seconds < 2)
        {
            if (playAudio1)
            {
                playAudio1 = false;
                audioSource.PlayOneShot(house1);
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(603, 3.25f, 600), step);
        }
        else if(seconds < 5)
        {
            rotateToY(1.2f, 263.064f);
        }
        else if (seconds < 8)
        {
            if (playAudio2)
            {
                playAudio2 = false;
                audioSource.PlayOneShot(house2);
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(594.64f, 3.25f, 598.736f), step);
        }
        else if (seconds < 12)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(593.59f, 3.25f, 602.311f), step/1.4f);
            rotateToY(1.2f, 0);
        }
        else if (seconds < 14)
        {
            if (playAudio3)
            {
                playAudio3 = false;
                audioSource.PlayOneShot(house3);
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(589.8f, 3.25f, 601.18f), step);
            rotateToY(1.2f, -90);
        }
        else if (seconds < 19)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(596.893f, 3.25f, 598.196f), step);
            rotateToY(1.2f, 100);
        }
        else if (seconds < 21)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(597.818f, 3.25f, 595.754f), step);
            rotateToY(1.2f, 151.746f);
        }
        else if (seconds < 26)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(609.254f, 3.25f, 594.061f), step);
            rotateToY(1.2f, 90);
        }
        else if (seconds < 28)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(612.96f, 0.89f, 594.061f), step);
            rotateToY(1.2f, 90);
        }
        else if (seconds < 32)
        {
            if (playAudio4)
            {
                playAudio4 = false;
                audioSource.PlayOneShot(house4);
            }
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(619.259f, 0.89f, 594.061f), step);
            rotateToY(1.2f, 90);
        }
        else if (seconds < 34)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(621.7f, 0.89f, 593.17f), step);
            rotateToY(1.2f, 109.282f);
        }
        else if(seconds < 36)
        {
            transform.position = new Vector3(622.926f, 0.13f, 593.026f);
            rotateToY(1.2f, 0);
        }
        else if(seconds < 45)
        {
            rotateToY(1.2f, 0);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(622.954f, 0.336f, 858.599f), step * 10);
            car.transform.position = Vector3.MoveTowards(car.transform.position, new Vector3(623.49f, 0.09f, 858.466f), step * 10);
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
