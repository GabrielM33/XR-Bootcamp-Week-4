using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Shoot : MonoBehaviour
{
    public Animator shootAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        shootAnimator.ResetTrigger("Shoot");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            shootAnimator.SetTrigger("Shoot");
        }
    }
}
