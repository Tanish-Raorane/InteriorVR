using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowGameMenu : MonoBehaviour
{
    public GameObject gameMenu;
    public InputActionProperty menuButton;

    public Transform head;
    private float spawnDistance = 1;
   
    void Start()
    {
        
    }

    

    void Update()
    {
        if(menuButton.action.WasPressedThisFrame())
        {
          if(!gameMenu.activeInHierarchy)
            {
                gameMenu.SetActive(true);
                gameMenu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
            }
            
          else
            {
                gameMenu.SetActive(false);
            }

        }

        gameMenu.transform.LookAt(new Vector3(head.position.x, gameMenu.transform.position.y, head.position.z));
        gameMenu.transform.forward *= -1;
    }
}
