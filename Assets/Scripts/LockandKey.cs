using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockandKey : MonoBehaviour
{
    public Animation doorAnimation;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            doorAnimation.Play("DoorAnim2");
        }
    }
}