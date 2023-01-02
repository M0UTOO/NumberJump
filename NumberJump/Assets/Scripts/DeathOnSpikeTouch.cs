using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathOnSpikeTouch : MonoBehaviour
{
    // a capsule collider is used to detect the player
    public CapsuleCollider playerCollider;
    public BoxCollider zoneToKill;

    // Update is called once per frame
    void Update()
    {
        // if the player collider is in the zone to kill the player dies
        if (playerCollider.bounds.Intersects(zoneToKill.bounds))
        {
            // reload the scene
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

    }
}
