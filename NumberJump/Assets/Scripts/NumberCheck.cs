using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberCheck : MonoBehaviour
{
    public GameObject inputMenuUI;
    public GameObject cameraFollow;
    public GameObject door;
    public GameObject clickMeField;
    TextMeshProUGUI clickMeField_text;


    public void GetInput(string guess)
    {
        string code = EventsOnStart.random.ToString();
        if(guess == code)
        {
            clickMeField_text = clickMeField.GetComponent<TextMeshProUGUI>();
            clickMeField_text.text = "You got it!";
            door.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            cameraFollow.SetActive(true);
            inputMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }else
        {
            clickMeField_text = clickMeField.GetComponent<TextMeshProUGUI>();
            clickMeField_text.text = "Try again!";
            Cursor.lockState = CursorLockMode.Locked;
            cameraFollow.SetActive(true);
            inputMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
