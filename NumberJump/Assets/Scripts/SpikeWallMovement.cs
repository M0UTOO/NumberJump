using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeWallMovement : MonoBehaviour
{

    public float speed = 1f;
    public float distance = 1f;
    public bool moveForward = false;
    // a capsule collider is used to detect the player
    public CapsuleCollider playerCollider;
    // a box collider is used to detect the zone to run
    public BoxCollider zoneToRun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the player is in the zone to run make the spike wall move forward
        if (playerCollider.bounds.Intersects(zoneToRun.bounds))
        {
            moveForward = true;
        }else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
