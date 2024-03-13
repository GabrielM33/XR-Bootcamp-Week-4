using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    public GameObject[] bodyParts;
    
    public float explosionForce;
    public float explosionRadius;
    public Vector3 explosionCenterOffset = Vector3.zero;
    
    private bool isRagdolled = false;

    // References to the original components
    private Collider[] originalColliders;
    private HingeJoint[] originalHingeJoints;

    private void Start()
    {
        GetOriginalComponents(); 
        //Invoke("EnableRagdoll", 5f);
    }
    
    private void GetOriginalComponents()
        {
            originalColliders = GetComponentsInChildren<Collider>();
            originalHingeJoints = GetComponentsInChildren<HingeJoint>();
        }
    
    /*
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Bomb") && !isRagdolled)
        {
            isRagdolled = true;
            EnableRagdoll();
        }
    }
    */

    public void EnableRagdoll() 
    {
        DisableOriginalComponents();

        foreach (GameObject part in bodyParts)
        {
            if (part) {
                GameObject newPart = Object.Instantiate(part, part.transform.position, part.transform.rotation); 
                Rigidbody rb = newPart.AddComponent<Rigidbody>(); 
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
    }

    private void DisableOriginalComponents()
    {
        foreach (Collider col in originalColliders) col.enabled = false;
        foreach (HingeJoint joint in originalHingeJoints) joint.breakForce = 5f; 
    }
}