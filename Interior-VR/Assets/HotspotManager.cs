using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotManager : MonoBehaviour
{
    public GameObject xrOrigin;
    public GameObject All, LivingRoom, Kitchen, DiningRoom, Bedroom1, Bedroom2, Bedroom3;
    public Transform Maincamera;
    public GameObject leftController;
    public GameObject rightController;
    public GameObject leftRay;
    public GameObject rightRay;
    public GameObject menu;
    
    Vector3 difference;

    int count = 0;
    float LerpSpeed = 1;

    //private Vector3 StartPosition;
    //private Vector3 EndPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;

    //public CharacterController cc;
    void Start()
    {
        
        
    }

    //public void SetHotspotFromIndex(int index)
    //{
        
    //}

   public void OnPressLivingRoom()
    {
        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);

        //All.transform.SetParent()

    }

    public void OnPressKitchen()
    {
        
    }

    public void OnPressDiningRoom()
    {

    }

    public void OnPressBedroom1()
    {

    }

    public void OnPressBedroom2()
    {

    }

    public void OnPressBedroom3()
    {
        //count = 1;
        //StartPosition = xrOriginParent.position;
        //EndPosition = new Vector3(empty.position.x, StartPosition.y, empty.position.z);
        //leftRay.SetActive(false);
        //rightRay.SetActive(false);
        //menu.SetActive(false);
        //StartCoroutine(Coroutine());

        //leftController.SetActive(false);
        //rightController.SetActive(false);
        //leftRay.SetActive(false);
        //rightRay.SetActive(false);
        //xrOriginParent.transform.position = new Vector3(empty.transform.position.x, xrOriginParent.transform.position.y, empty.transform.position.z);
        //xrOriginParent.position = new Vector3((float)-0.936, (float)0.455, (float)-2.13);

        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);




        All.transform.SetParent(Kitchen.transform);
        Kitchen.transform.SetParent(Bedroom3.transform);
        //empty1.transform.position = Maincamera.position;
        xrOrigin.transform.rotation = Bedroom3.transform.rotation;
        StartCoroutine(Coroutine(Bedroom3.transform.position, Maincamera.position, Bedroom3));
    }

    public void OnPress2()
    {

        All.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
       

        All.transform.SetParent(Bedroom3.transform);
        Bedroom3.transform.SetParent(Kitchen.transform);
        //empty2.transform.position = Maincamera.position;
        xrOrigin.transform.rotation = Kitchen.transform.rotation;
        StartCoroutine(Coroutine(Kitchen.transform.position, Maincamera.position, Kitchen));
    }


    public IEnumerator Coroutine(Vector3 StartPosition, Vector3 EndPosition, GameObject empty)
    {
        float time = 0;
        while (time < 1)
        {
            empty.transform.position = Vector3.Lerp(StartPosition, EndPosition, time);
            time += Time.deltaTime * LerpSpeed;
            yield return null;
        }
    }
    //public void SetHotspotOnIndex(int index)
    //{
    //    switch(index)
    //    {
    //        case 0: StartCoroutine
    //    }
    //}

    //public IEnumerator Coroutine()
    //{
    //    //cc.enabled = false;
    //    //print("Hi");

    //    float time = 0;
    //    while (time < 10)
    //    {
    //        xrOriginParent.transform.position = Vector3.Lerp(StartPosition, EndPosition, time);
    //        time += Time.deltaTime * LerpSpeed;
    //        yield return null;
    //    }

        //    //cc.enabled = true;

        //}


        void Update()
    {
        //if(count == 1)
        //{
        //    elapsedTime += Time.deltaTime;
        //    float percentageComplete = elapsedTime / desiredDuration;

        //    xrOriginParent.position = Vector3.Lerp(StartPosition, EndPosition, percentageComplete);

        //}

        //difference = empty.transform.position - Maincamera.position;
        
       
    }
}
