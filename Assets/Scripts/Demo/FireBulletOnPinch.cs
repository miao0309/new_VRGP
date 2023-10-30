using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnPinch : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public float bulletForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        // check if this object is grabbed by the hand

    }
    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody rb = newBullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletForce, ForceMode.VelocityChange);
        Destroy(newBullet, 5f);
    }
}
