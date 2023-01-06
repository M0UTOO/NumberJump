using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class BumperForward : MonoBehaviour
{
    public float bumperForce = 10000f;
    public CharacterController controller;
    public GameObject playerCapsule;
    public GameObject bumperCollider;

    // Update is called once per frame
    void Update()
    {
        if(bumperCollider.GetComponent<Collider>().bounds.Intersects(playerCapsule.GetComponent<Collider>().bounds))
        {
            controller.Move(transform.forward * bumperForce * Time.deltaTime);
        }
    }
}
