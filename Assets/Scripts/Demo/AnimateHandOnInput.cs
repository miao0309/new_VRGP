using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty grabAction;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAction.action.ReadValue<float>();
        float grabValue = grabAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", pinchValue);
        handAnimator.SetFloat("Grip", grabValue);
    }
}
