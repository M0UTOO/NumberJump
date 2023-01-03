using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void Back()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

}
