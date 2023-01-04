using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;
    public GameObject buttonMenuUI;
    public GameObject cameraFollow;

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
            }
        }
    }
}
