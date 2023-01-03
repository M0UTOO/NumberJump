using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject levelMenu;

    public void Back()
    {
        levelMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

}
