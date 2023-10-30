using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimaionHands : MonoBehaviour
{
    public InputActionProperty pinchAction; // Trigger
    public InputActionProperty grabAction; // Grip
    public Animator handAnimator;

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAction.action.ReadValue<float>();
        float grabValue = grabAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", pinchValue);
        handAnimator.SetFloat("Grip", grabValue);
    }
}

