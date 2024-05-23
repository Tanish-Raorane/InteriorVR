using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotManager : MonoBehaviour
{
    public Transform xrOrigin;
    public Transform empty;
    public GameObject leftController;
    public GameObject rightController;
    public GameObject leftRay;
    public GameObject rightRay;
    public GameObject menu;

    int count = 0;

    private Vector3 StartPosition;
    private Vector3 EndPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;

    void Start()
    {
        StartPosition = xrOrigin.position;
        
    }

    //public void SetHotspotFromIndex(int index)
    //{
        
    //}

    public void OnPress()
    {
        count = 1;
        EndPosition = new Vector3(EndPosition.x, StartPosition.y, EndPosition.z);
        leftController.SetActive(false);
        rightController.SetActive(false);
        leftRay.SetActive(false);
        rightRay.SetActive(false);
        menu.SetActive(false);

    }

    void Update()
    {
        if(count == 1)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / desiredDuration;

            xrOrigin.position = Vector3.Lerp(StartPosition, EndPosition, percentageComplete);

            if(percentageComplete == 1)
            {
                
                count = 0;
                leftController.SetActive(true);
                rightController.SetActive(true);
            }
        }
    }
}
