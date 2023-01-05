using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public int levelToLoad;
    public GameObject finishLineCollider;
    public GameObject endScreen;
    public GameObject playerCapsule;
    public GameObject cameraFollow;

    // Update is called once per frame
    void Update()
    {
      if(finishLineCollider.GetComponent<Collider>().bounds.Intersects(playerCapsule.GetComponent<Collider>().bounds))
      {
        if(levelToLoad == 1)
        {
          SceneManager.LoadScene("Level2");
        }
        else if(levelToLoad == 2)
        {
        Cursor.lockState = CursorLockMode.None;
        playerCapsule.SetActive(false);
        cameraFollow.SetActive(false);
          StartCoroutine(loadEndScreen());
        }
      }
  }

  IEnumerator loadEndScreen()
  {

    endScreen.SetActive(true);
    yield return new WaitForSeconds(5);
    SceneManager.LoadScene("MainMenu");
  }
}