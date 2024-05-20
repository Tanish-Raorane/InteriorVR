using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty grabAction;

    public Animator handAnimator;

    void Start()
    {
        
    }

    
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float grabValue = grabAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", grabValue);
    }
}
