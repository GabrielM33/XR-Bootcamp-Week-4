using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockandKey2 : MonoBehaviour
{
    public Animation doorAnimation;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key2"))
        {
            doorAnimation.Play("DoorAnim3");
        }
    }
}