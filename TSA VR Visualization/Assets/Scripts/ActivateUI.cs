using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    [SerializeField]
    private Canvas UI;
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private Camera playerCam;
    private int prevCollisions = 0;
    private int CollisionsWithCube = 0;
    private bool displayUI = false; 


    // Update is called once per frame
    void Update()
    {
        DetectObjectWithRaycast();
        UI.gameObject.SetActive(displayUI);
    }
    
    private void DetectObjectWithRaycast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.name == "Cube")
                {
                    displayUI = !displayUI;
                }
            }
        }
    }
}
