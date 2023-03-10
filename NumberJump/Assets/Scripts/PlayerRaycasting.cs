using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;
    public GameObject buttonMenuUI;
    public GameObject cameraFollow;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, distanceToSee))
            {
                if(hit.collider.tag == "Button")
                {
                    EventsOnStart.IsStarted = false;
                    buttonMenuUI.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    cameraFollow.SetActive(false);
                    Time.timeScale = 0f;
                }
                if(hit.collider.tag == "Target")
                {
                    player.transform.position = hit.collider.transform.position + new Vector3(0, 5, 0);
                }
            }
        }
    }
}
