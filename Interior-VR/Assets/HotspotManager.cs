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

        All.transform.SetParent(LivingRoom.transform);
        Kitchen.transform.SetParent(LivingRoom.transform);
        DiningRoom.transform.SetParent(LivingRoom.transform);
        Bedroom1.transform.SetParent(LivingRoom.transform);
        Bedroom2.transform.SetParent(LivingRoom.transform);
        Bedroom3.transform.SetParent(LivingRoom.transform);
        //xrOrigin.transform.rotation = LivingRoom.transform.rotation;
        StartCoroutine(Coroutine(LivingRoom.transform.position, Maincamera.position, LivingRoom));
       

    }

    public void OnPressKitchen()
    {
        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);

        All.transform.SetParent(Kitchen.transform);
        LivingRoom.transform.SetParent(Kitchen.transform);
        DiningRoom.transform.SetParent(Kitchen.transform);
        Bedroom1.transform.SetParent(Kitchen.transform);
        Bedroom2.transform.SetParent(Kitchen.transform);
        Bedroom3.transform.SetParent(Kitchen.transform);

        StartCoroutine(Coroutine(Kitchen.transform.position, Maincamera.position, Kitchen));

    }

    public void OnPressDiningRoom()
    {
        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);

        All.transform.SetParent(DiningRoom.transform);
        LivingRoom.transform.SetParent(DiningRoom.transform);
        Kitchen.transform.SetParent(DiningRoom.transform);
        Bedroom1.transform.SetParent(DiningRoom.transform);
        Bedroom2.transform.SetParent(DiningRoom.transform);
        Bedroom3.transform.SetParent(DiningRoom.transform);

        StartCoroutine(Coroutine(DiningRoom.transform.position, Maincamera.position, DiningRoom));

    }

    public void OnPressBedroom1()
    {
        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);

        All.transform.SetParent(Bedroom1.transform);
        LivingRoom.transform.SetParent(Bedroom1.transform);
        Kitchen.transform.SetParent(Bedroom1.transform);
        DiningRoom.transform.SetParent(Bedroom1.transform);
        Bedroom2.transform.SetParent(Bedroom1.transform);
        Bedroom3.transform.SetParent(Bedroom1.transform);

        StartCoroutine(Coroutine(Bedroom1.transform.position, Maincamera.position, Bedroom1));
    }

    public void OnPressBedroom2()
    {
        All.transform.SetParent(null);
        LivingRoom.transform.SetParent(null);
        Kitchen.transform.SetParent(null);
        DiningRoom.transform.SetParent(null);
        Bedroom1.transform.SetParent(null);
        Bedroom2.transform.SetParent(null);
        Bedroom3.transform.SetParent(null);

        All.transform.SetParent(Bedroom2.transform);
        LivingRoom.transform.SetParent(Bedroom2.transform);
        Kitchen.transform.SetParent(Bedroom2.transform);
        DiningRoom.transform.SetParent(Bedroom2.transform);
        Bedroom1.transform.SetParent(Bedroom2.transform);
        Bedroom3.transform.SetParent(Bedroom2.transform);

        StartCoroutine(Coroutine(Bedroom2.transform.position, Maincamera.position, Bedroom2));
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

        All.transform.SetParent(Bedroom3.transform);
        LivingRoom.transform.SetParent(Bedroom3.transform);
        Kitchen.transform.SetParent(Bedroom3.transform);
        DiningRoom.transform.SetParent(Bedroom3.transform);
        Bedroom1.transform.SetParent(Bedroom3.transform);
        Bedroom2.transform.SetParent(Bedroom3.transform);
        StartCoroutine(Coroutine(Bedroom3.transform.position, Maincamera.position, Bedroom3));
    }

    public IEnumerator Coroutine(Vector3 StartPosition, Vector3 EndPosition, GameObject hotspot)
    {
        float time = 0;
        while (time < 1)
        {
            hotspot.transform.position = Vector3.Lerp(StartPosition, EndPosition, time);
            time += Time.deltaTime * LerpSpeed;
            yield return null;
        }

        hotspot.transform.rotation = xrOrigin.transform.rotation;

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
