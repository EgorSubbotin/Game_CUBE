using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody rb;
    public float sidewaysForce = 600f;
    public void OnPointerDown(PointerEventData date)
    {
        if (gameObject.name == "LeftButton")
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (gameObject.name == "RightButton")
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    public void OnPointerUp(PointerEventData date)
    {
        rb.AddForce(0, 0, 0, ForceMode.VelocityChange);
    }

}
