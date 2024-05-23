using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowGameMenu : MonoBehaviour
{
    public GameObject gameMenu;
    public InputActionProperty menuButton;

    public Transform head;
    private float spawnDistance = 1;

    public GameObject leftRay, rightRay;
    
    
    //public XRInteractorLineVisual xrLine;
    //Gradient newGradient = new Gradient();


    void Start()
    {
       
        //GradientAlphaKey[] alphaKeys = new GradientAlphaKey[2];
        //alphaKeys[0].alpha = 1.0f;
        //alphaKeys[0].time = 0.0f;
        //alphaKeys[1].alpha = 1.0f;
        //alphaKeys[1].time = 0.0f;
        //newGradient.alphaKeys = alphaKeys;
        
    }

    

    void Update()
    {
        if(menuButton.action.WasPressedThisFrame())
        {
          if(!gameMenu.activeInHierarchy)
            {
                gameMenu.SetActive(true);
                gameMenu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
                //xrLine.invalidColorGradient = newGradient;
                leftRay.SetActive(true);
                rightRay.SetActive(true);
                
            }
            
          else
            {
                gameMenu.SetActive(false);
                leftRay.SetActive(false);
                rightRay.SetActive(false);

            }

        }

        gameMenu.transform.LookAt(new Vector3(head.position.x, gameMenu.transform.position.y, head.position.z));
        gameMenu.transform.forward *= -1;
    }
}
