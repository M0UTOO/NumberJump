using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.red);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit, distanceToSee))
        {
            if(hit.collider.gameObject.tag == "Button")
            {
                hit.collider.gameObject.GetComponent<ButtonPress>().ButtonClicked();
            }
        }
    }
    */
}
