using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public float bumpForce;
    
    private void OnTriggerEnter(Collider other)
    {
        
        var rb = other.GetComponent<Rigidbody>();
        if (null == rb)
        {
            return;
        }
        
        rb.AddForce(Vector3.up * bumpForce, ForceMode.VelocityChange);
    }
}
