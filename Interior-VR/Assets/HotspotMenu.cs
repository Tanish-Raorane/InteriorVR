using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HotspotMenu : MonoBehaviour
{
    public InputActionProperty hotspotButton;
    public GameObject hotspotMenu;
    public GameObject LeftRay, RightRay;
    public Transform Head;
    private float SpawnDistance = 1;
    public ShowGameMenu textureMenu;


    void Start()
    {
        
    }

   
    void Update()
    {
        if(hotspotButton.action.WasPressedThisFrame())
        {
            if (!hotspotMenu.activeInHierarchy)
            {
                textureMenu.gameMenu.SetActive(false);
                hotspotMenu.SetActive(true);
                hotspotMenu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * SpawnDistance;
                //xrLine.invalidColorGradient = newGradient;
                LeftRay.SetActive(true);
                RightRay.SetActive(true);

            }

            else
            {
                hotspotMenu.SetActive(false);
                LeftRay.SetActive(false);
                RightRay.SetActive(false);

            }


        }

        hotspotMenu.transform.LookAt(new Vector3(Head.position.x, hotspotMenu.transform.position.y, Head.position.z));
        hotspotMenu.transform.forward *= -1;

        hotspotMenu.transform.position = new Vector3(hotspotMenu.transform.position.x, Head.transform.position.y, hotspotMenu.transform.position.z);
    }
}
