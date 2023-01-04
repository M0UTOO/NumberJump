using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public GameObject finishLineCollider;
    public GameObject playerCapsule;

    // Update is called once per frame
    void Update()
    {
      if(finishLineCollider.GetComponent<Collider>().bounds.Intersects(playerCapsule.GetComponent<Collider>().bounds))
      {
        SceneManager.LoadScene("Level2");
      }
    }
}
