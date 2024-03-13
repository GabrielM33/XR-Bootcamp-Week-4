using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class RoboGiblets : MonoBehaviour
{
    public GameObject[] bodyParts;
    public float explosionForce = 100f;
    public float explosionRadius = 5f;

    private void Start()
    {
        Invoke("Explode", 15f);
    }

    public void Explode() 
    {
        foreach (GameObject part in bodyParts)
        {
            if (part) {
                GameObject newPart = Object.Instantiate(part, part.transform.position, part.transform.rotation); 
                Rigidbody rb = newPart.AddComponent<Rigidbody>(); 
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
                rb.useGravity = true;
                rb.isKinematic = false; 

                part.SetActive(false);
            }
        }
    }
}